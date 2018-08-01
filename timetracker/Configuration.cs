using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timetracker
{
	class Configuration
	{
		private static int _screenshottingFrequency = -1;
		public static int ScreenshottingFrequency
		{
			get
			{
				if (_screenshottingFrequency < 1)
				{
					// TODO: Fetch from registry
					Microsoft.Win32.RegistryKey key;

					key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("AdminRegistry");
					key.GetValue("30");
					key.Close();

					_screenshottingFrequency = 30;
				}
				return _screenshottingFrequency;
			}
			set
			{
				// TODO: save to registry
				Microsoft.Win32.Registry.CurrentUser.DeleteSubKey("AdminRegstry");

				Microsoft.Win32.Registry.CurrentUser.OpenSubKey("AdminRegistry", true);


				{
					System.Windows.MessageBox.Show("Screenshotting every 30sec");



					_screenshottingFrequency = value;
				}
			}
		}
	}
}
