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
    class TapProcesses : ITimerAdvisor
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        public static extern UInt32 GetWindowThreadProcessId(IntPtr hwnd, ref Int32 pid);

        [DllImport("kernel32.dll")]
        static extern int GetProcessId(IntPtr handle);

        private string processName = "";

        private bool inWhiteList = true;
        private bool inBlackList = true;



        private static TapProcesses _instance = null;
        private ThreadStart threadStart;
        private Thread childThread;

 /*       public static TapProcesses Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TapProcesses(bool allovdedProcess);
                }
                return _instance;
            }
        }
*/


        public TapProcesses(bool allovdedProcess)
        {
            allovdedProcess = inWhiteList;
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
            while (true)
            {
                Process activeProcess = GetActiveProcess();
                if (activeProcess != null)
                {
                    GetActiveBrowser(activeProcess);
                   // Console.WriteLine(GetActiveBrowser(activeProcess));
                    //if 
                }
                // GetActiveWindow();
            }
        }

        private Process GetActiveProcess()
        {
            int pid = 0;
            IntPtr handle = GetForegroundWindow();
            GetWindowThreadProcessId(handle, ref pid);
            Process activeProcess = Process.GetProcessById(pid);
            if (activeProcess != null) return activeProcess;
            return null;
        }

        private bool GetActiveBrowser(Process activeProcess)
        {
            Dictionary<string, string> BrowserUrlFieldPropertyNames = new Dictionary<string, string>();
            BrowserUrlFieldPropertyNames.Add("chrome", "Address and search bar"); //chrome
            //BrowserUrlFieldPropertyNames.Add("firefox", "Search or enter address"); //FireFox
            BrowserUrlFieldPropertyNames.Add("iexplore", "Address and search using Bing"); //IE
            BrowserUrlFieldPropertyNames.Add("ApplicationFrameHost", "Search or enter web address"); //EDGE
            BrowserUrlFieldPropertyNames.Add("opera", "Address field"); //opera


            AutomationElement UrlBarElement = null;
            AutomationElement mainWindowElement = null;
            AutomationElement rootElement = null;

            // Console.WriteLine(BrowserUrlFieldPropertyNames.Count);


            foreach (var browser in BrowserUrlFieldPropertyNames)
            {
                if (browser.Key != activeProcess.ProcessName) continue;
                else
                {
                    mainWindowElement = AutomationElement.FromHandle(activeProcess.MainWindowHandle);

                    if (mainWindowElement == null) return false;

                    AutomationElement elmUrlBar = mainWindowElement.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, browser.Value));

                    if (elmUrlBar != null)
                    {
                        // Console.WriteLine(elmUrlBar.Current.Name);

                        return CheckUrl(((ValuePattern)elmUrlBar.GetCurrentPattern(ValuePattern.Pattern)).Current.Value);// as string;
                        // was return

                        //return true;
                    }
                    else return false;
                    
                }
            }

            
            return GetActiveWindow(activeProcess);
        }

        private bool CheckUrl(string Url)
        {
            if (Url == "" || Url == null || Url.Length < 3) return true;

            string protocolPattern = @"\w*:\/\/";
            // var protocolPattern = new Regex(@"/\w *:\/\//gi");
            Regex r = new Regex(@protocolPattern, RegexOptions.IgnoreCase);

            Match m = r.Match(Url);

            int found = Url.IndexOf("//");
            if (found < 1) return true;
            Url = Url.Substring(found + 2);

            found = Url.IndexOf("/");
            if (found < 1) return true;
            Url = Url.Remove(found);

            Console.WriteLine("NEW URL = " + Url);
            if (Url == "facebook.com") return false;
            return true;
        }
        

        private bool GetActiveWindow(Process activeProcess)
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);

            // GetProcessURL(activeProcess);

            if (activeProcess.ProcessName == "firefox") return false;
/*
            //getting active window handle
            if (GetWindowText(activeProcess.MainWindowHandle, Buff, nChars) > 0)
            {
                if (Buff.ToString() == "firefox") { return false; }
                else {
                    // name = Buff.ToString();

                  //  Console.WriteLine(Buff.ToString());
                    return true;
                }
            }*/
            return true;
        }
        
    
        public bool AdviseIfCanCount()
        {
            return true;
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
