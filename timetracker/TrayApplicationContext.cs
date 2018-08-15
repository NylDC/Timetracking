using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using timetracker.Properties;
using timetracker.Services;

namespace timetracker
{
    class TrayApplicationContext : ApplicationContext
    {
        private NotifyIcon trayIcon;
        public ContextMenu contextMenu;
        private static TrayApplicationContext _instance = null;

        private AboutForm aboutForm;
		private EmployeeLogin employeeLogin;

		private TimerDisplay timerDisplay;

		private AdminDashboardForm adminDashboardForm;
        private MyStatsForm myStatsForm;

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
            Auth.CounterChange += OnAuthChange;
            TraySetNoAuth();
        }

        void OnAuthChange(AuthEventArgs e)
        {
            if(e.User != null)
            {
                if(e.User.IsAdmin)
                {
                    TraySetForAdmin();
                }
                else
                {
                    TraySetForUser();
                }
            }
            else
            {
                TraySetNoAuth();
            }
        }

        void TraySetForAdmin()
        {
            InitTrayIcon(new List<MenuItem> {
                new MenuItem("Preferences", Preferences_Click),
            });
        }

        void TraySetForUser()
        {
            MenuItem defaultItem;
            InitTrayIcon(new List<MenuItem> {
                (defaultItem = new MenuItem("Toggle Timer", Icon_Click)),
                new MenuItem("Stats", Stats_Click),
            });
            defaultItem.DefaultItem = true;
            trayIcon.DoubleClick += Icon_Click;
        }

        void TraySetNoAuth()
        {
            MenuItem defaultItem;
            InitTrayIcon(new List<MenuItem> {
                (defaultItem = new MenuItem("Login", Login_Click)),
            });
            defaultItem.DefaultItem = true;
            trayIcon.DoubleClick += Login_Click;
        }

        NotifyIcon InitTrayIcon(List<MenuItem> menuItems) {
            if (trayIcon != null)
            {
                trayIcon.Dispose();
            }
            if(Auth.CurrentUser != null)
            {
                menuItems.Add(new MenuItem("-"));
                menuItems.Add(new MenuItem("Logout", Logout_Click));
            }
            menuItems.Add(new MenuItem("-"));
            menuItems.Add(new MenuItem("About", About_Click));
            menuItems.Add(new MenuItem("Exit", Exit_Click));
            contextMenu = new ContextMenu(menuItems.ToArray());
            // Initialize Tray Icon
            trayIcon = new NotifyIcon()
            {
                Icon = Resources.AppIcon,
                ContextMenu = contextMenu,
                Visible = true
            };
            return trayIcon;
        }

        void Icon_Click(object sender, EventArgs e)
        {
            if (timerDisplay == null || timerDisplay.IsDisposed)
            {
                timerDisplay = new TimerDisplay();
                timerDisplay.Left = Screen.PrimaryScreen.WorkingArea.Width - timerDisplay.Size.Width;
                timerDisplay.Top = Screen.PrimaryScreen.WorkingArea.Height - timerDisplay.Size.Height;
                timerDisplay.Show();
            }
            else
                timerDisplay.Visible = !timerDisplay.Visible;
        }

        void Logout_Click(object sender, EventArgs e)
        {
            Auth.Logout();
        }

        void Exit_Click(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;

            Application.Exit();
        }

		void Login_Click(object sender, EventArgs e)
		{
			// Open About window

			if (employeeLogin == null || employeeLogin.IsDisposed)
			{
				employeeLogin = new EmployeeLogin();
			}
            employeeLogin.Show();
            employeeLogin.Activate();
		}

		void About_Click(object sender, EventArgs e)
        {
            // Open About window

            if (aboutForm == null || aboutForm.IsDisposed)
            {
                aboutForm = new AboutForm();
            }
            aboutForm.Show();
            aboutForm.Activate();
        }

		void Preferences_Click(object sender, EventArgs e)
		{
			// Open admin Dashboard window
			if (adminDashboardForm == null || adminDashboardForm.IsDisposed)
			{
				adminDashboardForm = new AdminDashboardForm();
            }
            adminDashboardForm.Show();
            adminDashboardForm.Activate();
		}

        void Stats_Click(object sender, EventArgs e)
        {
            // Open admin Dashboard window
            if (myStatsForm == null || myStatsForm.IsDisposed)
            {
                myStatsForm = new MyStatsForm();
            }
            myStatsForm.Show();
            myStatsForm.Activate();
        }
    }
}
