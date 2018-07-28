using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timetracker.Services;

namespace timetracker.Advisors
{
    class TapBrowsers : ITimerAdvisor
    {
        public bool AdviseIfCanCount()
        {
            return true;
        }
    }
}
