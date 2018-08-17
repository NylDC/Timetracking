using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows;
using DotImaging;
using System.Drawing.Imaging;
using timetracker.Structs;

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
                mkVideo();
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
        private static string DirectoryName => GetDirectoryName(Auth.CurrentUser);

        public static string GetDirectoryName(User user)
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\timetracker\\" + user.Login;
        }
        private string getNewFileName()
        {
            string filename = @"\" + Tag + "_" + TimeStamp + ".jpeg";
            return DirectoryName + string.Format(filename);
        }

        public static void mkVideo()
        {
            var screenSize = ScreenSize;
            var videoSize = new DotImaging.Primitives2D.Size(screenSize.X, screenSize.Y);
            string videoTarget = DirectoryName + @"\" + Tag + "_" + TimeStamp + ".avi";
            Console.WriteLine(string.Format("Writing video file: {0}", videoTarget));

            ImageDirectoryCapture images = new ImageDirectoryCapture(DirectoryName, Tag + "_*.jpeg");
            if (images.Length == 0) return;
            ImageStreamWriter videoWriter = new VideoWriter(videoTarget, videoSize, Configuration.VideoFPS);
            List<string> toDelete = new List<string>();

            while(images.Position < images.Length){
                string f = images.CurrentImageName;
                Console.WriteLine(string.Format("   frame: {0}", f));
                IImage image = images.Read();
                videoWriter.Write(image);
                toDelete.Add(f);
            }
            videoWriter.Close();
            Console.WriteLine("END writing video");
            Console.WriteLine("Removing frame files");
            foreach(string f in toDelete)
            {
                if (f == null) continue;
                File.Delete(f);
                Console.WriteLine(string.Format("Deleted file: {0}", f));
            }
            Console.WriteLine("Done Removing frame files");
        }
    }
}
