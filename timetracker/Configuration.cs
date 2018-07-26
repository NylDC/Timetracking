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
			get {
				if(_screenshottingFrequency < 1)
				{
					// TODO: Fetch from registry
					_screenshottingFrequency = 3;
				}
				return _screenshottingFrequency;
			}
			set {
				// TODO: save to registry
				_screenshottingFrequency = value; }
		}
	}
}
