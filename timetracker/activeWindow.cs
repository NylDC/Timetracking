using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;


public static extern IntPtr GetForegroundWindow();

public static extern UInt32 GetWindowThreadProcessId(IntPtr hwnd, ref Int32 pid);


namespace timetracker
{
   
    class activeWindow
    {
       


        public void ActiveWindowWriteToFile()
        {
 


        IntPtr h = GetForegroundWindow();
            int pid = 0;
            GetWindowThreadProcessId(h, ref pid);
            Process p = Process.GetProcessById(pid);
            Console.Write("pid: {0}; window: {1}", pid, p.MainWindowTitle);


            try
            {

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\Users\\programmaker\\Documents\\Test.txt");

                //Write a line of text
                sw.WriteLine("pid: {0}; window: {1}", pid, p.MainWindowTitle);

              
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }



        }



    }
}
