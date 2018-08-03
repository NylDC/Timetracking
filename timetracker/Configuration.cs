using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
namespace timetracker
{
	class Configuration
	{
		private static int _screenshottingFrequency = -1;
		private const string REG_SECTION = "TimeTracker";
		private const string REG_SCRNSHOT = "ScreenshottingFrequency";
		public static int ScreenshottingFrequency 
		{
			get
			{
				if (_screenshottingFrequency < 1)
				{
					// TODO: Fetch from registry
					Microsoft.Win32.RegistryKey key;

					key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REG_SECTION);
					try
					{
						object o = key.GetValue(REG_SCRNSHOT, 5);
						_screenshottingFrequency = (Int32)o;
					}
#pragma warning disable CS0168 // Variable is declared but never used
					catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
					{
						_screenshottingFrequency = 5;
					}
					key.Close();


				}
				return _screenshottingFrequency;
			}
			set
			{
				// TODO: save to registry
				Microsoft.Win32.RegistryKey key;

				if (value < 1) value = 1;

				Microsoft.Win32.Registry.CurrentUser.OpenSubKey(REG_SECTION, true);
				key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REG_SECTION);
				key.SetValue(REG_SCRNSHOT, value);
				key.Close();





				{
					{
						System.Windows.MessageBox.Show("Screenshotting every 30sec");



						_screenshottingFrequency = value;
					}
				}
			}
		}
	}
}
