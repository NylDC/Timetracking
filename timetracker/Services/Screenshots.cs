using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows;
using DotImaging;
using System.Drawing.Imaging;
using timetracker.Structs;

namespace timetracker.Services
{
    /// <summary>
    /// Singleton class that manages screenshots
    /// </summary>
    public class Screenshots
    {
        /// <summary>
        /// Singleton instance
        /// </summary>
        private static Screenshots _instance = null;
        /// <summary>
        /// Containers for a separate thread that performs the action.
        /// </summary>
        private ThreadStart threadStart;
        private Thread childThread;

        /// <summary>
        /// Screenshotting singleton accessor
        /// </summary>
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

        /// <summary>
        /// Helper value provides information about the width/height of the current active screen
        /// </summary>
        public static Point ScreenSize => new Point(
                    (int)SystemParameters.PrimaryScreenWidth, (int)SystemParameters.PrimaryScreenHeight);

        /// <summary>
        /// Helper value provides wait interval
        /// </summary>
        public static int WaitTime => Configuration.ScreenshottingFrequency * 1000;

        /// <summary>
        /// Tag is used in file names
        /// </summary>
        private static string Tag = "task";

        /// <summary>
        /// Stat screenshotting with a custom tag
        /// </summary>
        /// <param name="tag"></param>
        public void Start(string tag)
        {
            Tag = tag;
            Start();
        }

        /// <summary>
        /// Start screenshotting with a default or previously defined tag.
        /// Creates target directory.
        /// </summary>
        public void Start()
        {
            if (childThread == null || !childThread.IsAlive)
            {
                Directory.CreateDirectory(DirectoryName);
                childThread = new Thread(threadStart);
                childThread.Start();
            }
        }

        /// <summary>
        /// Stops screenshotting. Creates a video file out of images that were taken for the current Tag.
        /// </summary>
        public void Stop()
        {
            if (childThread != null &&  childThread.IsAlive)
            {
                childThread.Abort();
                mkVideo();
            }
        }


        /// <summary>
        /// Main loop for the Thread
        /// </summary>
        private void Loop()
        {
            while (true)
            {
                Shoot();
                Thread.Sleep(WaitTime);
            }
        }

        /// <summary>
        /// Main action of the Thread loop. 
        /// Creates screenshot of an active screen and puts it on the disk.
        /// </summary>
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

        /// <summary>
        /// Creates video out of the latest screenshots made for the current Tag.
        /// </summary>
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
