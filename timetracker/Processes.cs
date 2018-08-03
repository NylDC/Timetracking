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

namespace timetracker
{
    class Processes
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


        

        private static Processes _instance = null;
        private ThreadStart threadStart;
        private Thread childThread;

        public static Processes Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Processes();
                }
                return _instance;
            }
        }

       

        public Processes()
        {
            threadStart = new ThreadStart(Loop);
        }

        ~Processes()
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
                GetActiveWindowTitle();
                //Thread.Sleep(WaitTime);
            }
        }


        
        public string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();
            int pid = 0;

            Dictionary<string, string> BrowserUrlFieldPropertyNames = new Dictionary<string, string>();
            BrowserUrlFieldPropertyNames.Add("chrome", "Address and search bar"); //chrome
            BrowserUrlFieldPropertyNames.Add("firefox", "Search or enter address"); //FireFox
            BrowserUrlFieldPropertyNames.Add("iexplore", "Address and search using Bing"); //IE
            BrowserUrlFieldPropertyNames.Add("ApplicationFrameHost", "Search or enter web address"); //EDGE
            BrowserUrlFieldPropertyNames.Add("opera", "Address field"); //opera

            GetWindowThreadProcessId(handle, ref pid);

            Process activeProcess = Process.GetProcessById(pid);


            if (activeProcess == null) return null;

            AutomationElement UrlBarElement = null;
            AutomationElement mainWindowElement = null;
            AutomationElement rootElement = null;

          //  Console.WriteLine("active process before browser checking = " + activeProcess.ProcessName);


            foreach (var browser in BrowserUrlFieldPropertyNames)
            {

           //     Console.WriteLine("active process after browser checking = " + activeProcess.ProcessName);


                if (browser.Key == activeProcess.ProcessName)
                {
                    mainWindowElement = AutomationElement.FromHandle(activeProcess.MainWindowHandle);

                    if (mainWindowElement == null)
                    {
                        Console.WriteLine("mainWindowElement = null");

                        return null;
                    }


                    //   AutomationElement aeDesktop = AutomationElement.RootElement;
                    //   Console.WriteLine ( browser.Value);


                    
                  // AutomationElement elmUrlBar = mainWindowElement.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.LocalizedControlTypeProperty, "edit"));


                    AutomationElement elmUrlBar = mainWindowElement.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, browser.Value));

                    if (elmUrlBar != null)
                    {
                        Console.WriteLine(elmUrlBar.Current.Name);
                        //return ((ValuePattern)elmUrlBar.GetCurrentPattern(ValuePattern.Pattern)).Current.Value as string;
                    }
                    else
                    {
                       // AutomationElement elmUrlBar1 = mainWindowElement.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.AccessKeyProperty, "Ctrl + L"));
                       // if (elmUrlBar1 != null)
                      //  {
                            Console.WriteLine("elmUrlBar = null");
                       // }

                       // return null;
                    }



                }
            }





           // GetProcessURL(activeProcess);

            //getting active window handle
            if (GetWindowText(handle, Buff, nChars) > 0)
            {
               

                
                if (Buff.ToString() == processName) { return null; }
                else {
                   // name = Buff.ToString();
                    

                    return Buff.ToString();
                }
            }
            return null;
        }
    }
}
