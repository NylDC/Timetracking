using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using timetracker.Properties;

namespace timetracker
{
    class TrayApplicationContext : ApplicationContext
    {
        private NotifyIcon trayIcon;
        public ContextMenu contextMenu;
        private static TrayApplicationContext _instance = null;

        private AboutForm aboutForm;
        private TimerDisplay timerDisplay;

		private AdminDashboardForm adminDashboardForm;



        public static TrayApplicationContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TrayApplicationContext();
                }
                return _instance;
            }
        }

        public TrayApplicationContext()
        {
            contextMenu = new ContextMenu(new MenuItem[] {

                new MenuItem("Start Screenshotting", ScreenshotingStart_Click),

                new MenuItem("STOP Screenshotting", ScreenshotingStop_Click),

                new MenuItem("About", About_Click),


				new MenuItem("Preferences", Preferences_Click),
				
				new MenuItem("Exit", Exit_Click),


            });
            // Initialize Tray Icon
            trayIcon = new NotifyIcon()
            {
                Icon = Resources.AppIcon,
                ContextMenu = contextMenu,
                Visible = true
            };

            trayIcon.Click += Icon_Click;
        }

        void ScreenshotingStart_Click(object sender, EventArgs e)
        {
            // Testing screenshot start
            Services.Screenshots.Instance.Start();
        }

        void ScreenshotingStop_Click(object sender, EventArgs e)
        {
            // Testing screenshot start
            Services.Screenshots.Instance.Stop();
        }

        void Icon_Click(object sender, EventArgs e)
        {
            if (timerDisplay == null)
            {
                timerDisplay = new TimerDisplay();
                timerDisplay.Show();
            }else
                timerDisplay.Visible = !timerDisplay.Visible;
        }

        void Exit_Click(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;

            Application.Exit();
        }

        void About_Click(object sender, EventArgs e)
        {
            // Open About window

            if (aboutForm == null)
            {
                aboutForm = new AboutForm();
                aboutForm.Show();
            }
            else { aboutForm.Activate(); }
        }

		void Preferences_Click(object sender, EventArgs e)
		{
			// Open admin Dashboard window

			if (adminDashboardForm == null)
			{
				adminDashboardForm = new AdminDashboardForm();
				adminDashboardForm.Show();
			}
			else { adminDashboardForm.Activate(); }
		}
	}
}
