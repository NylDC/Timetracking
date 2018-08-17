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
		private static int _maxKeyboardIdleInterval = -1;
        private static int _maxMouseIdleInterval = -1;
        private static int _showSplashFor = -1;
        private static int _videoFPS = -1;
        private const string REG_SECTION = "TimeTracker";
		private const string REG_SCRNSHOT = "ScreenshottingFrequency";
		private const string REG_MAXKII = "MaxKeyboardIdleInterval";
        private const string REG_MAXMII = "MaxMouseIdleInterval";
        private const string REG_SHOWSPLASH = "ShowSplashFor";
        private const string REG_VIDEOFPS = "VideoFPS";

        public static int ShowSplashFor
        {
            get
            {
                if (_showSplashFor < 0)
                    _showSplashFor = (Int32)ReadRegistryValue(REG_SHOWSPLASH, 5);

                return _showSplashFor;
            }
            set
            {
                if (value < 0) value = 0;
                _showSplashFor = (Int32)SaveRegistryValue(REG_SHOWSPLASH, value);
            }
        }
        public static int ScreenshottingFrequency 
		{
			get
			{
				if (_screenshottingFrequency < 1)
					_screenshottingFrequency = (Int32)ReadRegistryValue(REG_SCRNSHOT, 5);
				
				return _screenshottingFrequency;
			}
			set
			{
				if (value < 1) value = 1;
				_screenshottingFrequency = (Int32)SaveRegistryValue(REG_SCRNSHOT, value);
			}
		}

		public static int MaxKeyboardIdleInterval
		{
			get
			{
				if (_maxKeyboardIdleInterval < 1)
					_maxKeyboardIdleInterval = (Int32)ReadRegistryValue(REG_MAXKII, 5);

				return _maxKeyboardIdleInterval;
			}
			set
			{
				if (value < 1) value = 1;
				_maxKeyboardIdleInterval = (Int32)SaveRegistryValue(REG_MAXKII, value);
			}
		}

		public static int MaxMouseIdleInterval
		{
			get
			{
				if (_maxMouseIdleInterval < 1)
					_maxMouseIdleInterval = (Int32)ReadRegistryValue(REG_MAXMII, 5);

				return _maxMouseIdleInterval;
			}
			set
			{
				if (value < 1) value = 1;
				_maxMouseIdleInterval = (Int32)SaveRegistryValue(REG_MAXMII, value);
			}
		}

		private static object ReadRegistryValue(string keyName, object defaultValue)
		{
			object o = defaultValue;
			try
			{
				RegistryKey key = Registry.CurrentUser.CreateSubKey(REG_SECTION);
				o = key.GetValue(keyName, defaultValue);
				key.Close();
			}
#pragma warning disable CS0168 // Variable is declared but never used
			catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
			{
			}
			
			return o;
		}
		private static object SaveRegistryValue(string keyName, object theValue)
		{
			RegistryKey key = Registry.CurrentUser.CreateSubKey(REG_SECTION);
			key.SetValue(keyName, theValue);
			key.Close();
			return theValue;
		}

        public static float VideoFPS
        {
            get
            {
                if (_videoFPS < 1)
                    _videoFPS = (Int32)ReadRegistryValue(REG_VIDEOFPS, 2);

                return _videoFPS;
            }
            set
            {
                if (value < 1) value = 1;
                _videoFPS = (Int32)SaveRegistryValue(REG_VIDEOFPS, value);
            }
        }
    }
	
	
}
