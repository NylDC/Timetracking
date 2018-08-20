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
    /// <summary>
    /// The program itself. Invoked in the Program.cs. Manages Tray Icon and access to various windows.
    /// </summary>
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


        /// <summary>
        /// Singleton accessor
        /// </summary>
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
            (new SplashForm()).Show();
            Auth.CounterChange += OnAuthChange;
            TraySetNoAuth();
        }

        /// <summary>
        /// User change callback. Alters current Tray Menu
        /// </summary>
        /// <param name="e"></param>
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

        /// <summary>
        /// Create Tray Menu for an admin user
        /// </summary>
        void TraySetForAdmin()
        {
            InitTrayIcon(new List<MenuItem> {
                new MenuItem("Preferences", Preferences_Click),
            });
        }

        /// <summary>
        /// Create Tray Menu for a regular user
        /// </summary>
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

        /// <summary>
        /// Create Tray Menu for an unauthenticated user
        /// </summary>
        void TraySetNoAuth()
        {
            MenuItem defaultItem;
            InitTrayIcon(new List<MenuItem> {
                (defaultItem = new MenuItem("Login", Login_Click)),
            });
            defaultItem.DefaultItem = true;
            trayIcon.DoubleClick += Login_Click;
        }

        /// <summary>
        /// Create a standard application's tray menu with @menuItems on top.
        /// </summary>
        /// <param name="menuItems"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Toggle TimerDisplay form visibility. Available to a regular user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Logout menu action handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Logout_Click(object sender, EventArgs e)
        {
            Auth.Logout();
        }

        /// <summary>
        /// Exit menu action handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Exit_Click(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;

            Application.Exit();
        }

        /// <summary>
        /// Open login form form visibility. Available to a unauthenticated user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		void Login_Click(object sender, EventArgs e)
		{
			if (employeeLogin == null || employeeLogin.IsDisposed)
			{
				employeeLogin = new EmployeeLogin();
			}
            employeeLogin.Show();
            employeeLogin.Activate();
		}

        /// <summary>
        /// Open About form. Available to a any user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		void About_Click(object sender, EventArgs e)
        {
            if (aboutForm == null || aboutForm.IsDisposed)
            {
                aboutForm = new AboutForm();
            }
            aboutForm.Show();
            aboutForm.Activate();
        }

        /// <summary>
        /// Open Preferences form. Available to an admin user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Open Stats form. Available to a regular user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
