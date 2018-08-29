using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Automation;
using System.Web;
using System.Threading;
using System.Collections.Generic;
using timetracker.Services;
using System.Text.RegularExpressions;

namespace timetracker.Advisors
{
    public class TapProcesses : ITimerAdvisor
    {
        string[] forbiddenProcs = Configuration.ForbiddenProcesses;
        /// <summary>
        /// Importing objects and methods from Microsoft Windows' DLL for working with processes and windows 
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        public static extern UInt32 GetWindowThreadProcessId(IntPtr hwnd, ref Int32 pid);

        [DllImport("kernel32.dll")]
        static extern int GetProcessId(IntPtr handle);

        /// <summary>
        /// Definition of the active in this particular time process
        /// </summary>
        private Process activeProcess = null;

        /// <summary>
        /// Definition of the already getted process
        /// </summary>
        private Process CurProcess = null;
        
        /// <summary>
        /// Definition of the variable which shows is process or url is allowed or not
        /// </summary>
        private bool allovdedProcess = true;

        private ThreadStart threadStart;
        private Thread childThread;

        public TapProcesses(bool allovdedProcess)
        {
            
            threadStart = new ThreadStart(Loop);
            
        }

        ~TapProcesses()
        {
            Stop();
        }

        public void Start()
        {
            
              if (childThread == null || !childThread.IsAlive)
            {
                childThread = new Thread(threadStart);
                childThread.Start();
            }
            
            
        }

        public void Stop()
        {
            if (childThread.IsAlive)
            {
                childThread.Abort();
            }
        }

        
        private void Loop()
        {
            activeProcess = GetActiveProcess();
            if (activeProcess != null && CurProcess != activeProcess)
            {
                while (true)
                {
                    GetActiveBrowser(activeProcess);
                }
            }
        }

        /// <summary>
        /// Getting current active process
        /// </summary>
        /// <returns></returns>
        private Process GetActiveProcess()
        {
            int pid = 0;
            IntPtr handle = GetForegroundWindow();
            GetWindowThreadProcessId(handle, ref pid);
            activeProcess = Process.GetProcessById(pid);
            return activeProcess;
            
        }

        /// <summary>
        /// Checking if active process is web browser
        /// </summary>
        /// <param name="activeProcess"></param>
        private void GetActiveBrowser(Process activeProcess)
        {
            CurProcess = GetActiveProcess();
            Dictionary<string, string> BrowserUrlFieldPropertyNames = new Dictionary<string, string>();
            BrowserUrlFieldPropertyNames.Add("chrome", "Address and search bar"); //chrome
            //BrowserUrlFieldPropertyNames.Add("firefox", "Search or enter address"); //FireFox   //not finded yet
            BrowserUrlFieldPropertyNames.Add("iexplore", "Address and search using Bing"); //IE
            BrowserUrlFieldPropertyNames.Add("ApplicationFrameHost", "Search or enter web address"); //EDGE
            BrowserUrlFieldPropertyNames.Add("opera", "Address field"); //opera

            AutomationElement UrlBarElement = null;
            AutomationElement mainWindowElement = null;
            AutomationElement rootElement = null;
        
            foreach (var browser in BrowserUrlFieldPropertyNames)
            {
                if (browser.Key != activeProcess.ProcessName) continue;
                else
                {
                    
                    mainWindowElement = AutomationElement.FromHandle(activeProcess.MainWindowHandle);

                    if (mainWindowElement == null) allovdedProcess = false;

                    AutomationElement elmUrlBar = mainWindowElement.FindFirst(TreeScope.Descendants, 
                        new PropertyCondition(AutomationElement.NameProperty, browser.Value));

                    if (elmUrlBar != null)
                    {
                       
                        CheckUrl(((ValuePattern)elmUrlBar.GetCurrentPattern(ValuePattern.Pattern)).Current.Value);
                     
                    }
                   
                }
            }

            CheckProcess(CurProcess);
        }

        /// <summary>
        /// Checking if URL is alowed or not
        /// </summary>
        /// <param name="Url"></param>
        private void CheckUrl(string Url)
        {
            CurProcess = activeProcess;
            if (Url == "" || Url == null || Url.Length < 3) allovdedProcess = true;

            string protocolPattern = @"\w*:\/\/";
            // var protocolPattern = new Regex(@"/\w *:\/\//gi");
            Regex r = new Regex(@protocolPattern, RegexOptions.IgnoreCase);

            Match m = r.Match(Url);

            int found = Url.IndexOf("//");
            if (found < 1) allovdedProcess = true;
            else
            {
                Url = Url.Substring(found + 2);

                found = Url.IndexOf("/");
                if (found < 1) allovdedProcess = true;
                else Url = Url.Remove(found);
            }

            allovdedProcess = true;

            foreach (string proc in Configuration.ForbiddenUrls)
            {
                if (Url == proc || Url == "www." + proc)
                {
                    allovdedProcess = false;
                    break;
                }
            }

            

        }

        /// <summary>
        /// Checking if active process is alowed or not
        /// </summary>
        /// <param name="activeProcess"></param>
        private void CheckProcess(Process activeProcess)
        {
            allovdedProcess = true;

            foreach (string proc in forbiddenProcs)
            {
                if (activeProcess.ProcessName == proc)
                {
                    allovdedProcess = false;
                    break;
                }
            }
           
        }
        
    
        public bool AdviseIfCanCount()
        {
            
            return allovdedProcess ;
        }
    

        public void OnTimerStart()
        {
            Start();
        }

        public void OnTimerStop()
        {
            Stop();
        }
    }
}
