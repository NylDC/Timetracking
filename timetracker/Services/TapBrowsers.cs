using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timetracker.Services
{
    class TapBrowsers : ITimerAdvisor
    {
        public bool AdviseIfCanCount()
        {
            return true;
        }
    }
}
