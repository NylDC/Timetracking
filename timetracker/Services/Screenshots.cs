using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows;

namespace timetracker.Services
{
    class Screenshots
    {
        private static Screenshots _instance = null;
        private ThreadStart threadStart;
        private Thread childThread;

        public static Screenshots Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Screenshots();
                }
                return _instance;
            }
        }

        public Screenshots()
        {
            threadStart = new ThreadStart(Loop);
        }

        ~Screenshots()
        {
            Stop();
        }

        public static Point ScreenSize => new Point(
                    (int)SystemParameters.PrimaryScreenWidth, (int)SystemParameters.PrimaryScreenHeight);

        public static int WaitTime => Configuration.ScreenshottingFrequency * 1000;

        private static string Tag = "task";

        public void Start(string tag)
        {
            Tag = tag;
            Start();
        }
        public void Start()
        {
            if (childThread == null || !childThread.IsAlive)
            {
                Directory.CreateDirectory(DirectoryName);
                childThread = new Thread(threadStart);
                childThread.Start();
            }
        }

        public void Stop()
        {
            if (childThread != null &&  childThread.IsAlive)
            {
                childThread.Abort();
            }
        }


        private void Loop()
        {
            while (true)
            {
                Shoot();
                Thread.Sleep(WaitTime);
            }
        }
        private void Shoot()
        {
            Point screenSize = ScreenSize;
            Bitmap memoryImage;

            memoryImage = new Bitmap(screenSize.X, screenSize.Y);
            Size s = new Size(memoryImage.Width, memoryImage.Height);

            // Create graphics
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);

            // Copy data from screen
            Console.WriteLine("Copying data from screen...");
            Console.WriteLine();
            memoryGraphics.CopyFromScreen(0, 0, 0, 0, s);

            //That's it! Save the image in the directory and this will work like charm.
            string targetFile = getNewFileName();

            // Save it!
            Console.WriteLine(string.Format("Saving the image to {0}...", targetFile));
            memoryImage.Save(targetFile, ImageFormat.Jpeg);
        }

        private static string TimeStamp => DateTime.Now.ToString("yyyy-MM-dd-HHmmss-ffff");
        private static string DirectoryName => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\timetracker\\" + Auth.CurrentUser.Login;
        private string getNewFileName()
        {
            string filename = @"\" + Tag + "_" + TimeStamp + ".jpeg";
            return DirectoryName + string.Format(filename);
        }
    }
}
