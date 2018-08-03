using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timetracker.Services;

namespace timetracker.Advisors
{
    class TapProcesses : ITimerAdvisor
    {
        public bool AdviseIfCanCount()
        {
            return true;
        }

        public void OnTimerStart()
        {
        }

        public void OnTimerStop()
        {
        }
    }
}
