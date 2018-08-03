using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timetracker.Services;

namespace timetracker.Advisors
{
    class TapUserInput : ITimerAdvisor
    {

        private bool TapMouse = false;
        private bool TapKeyboard = false;
        public TapUserInput(bool tapKeyboard, bool tapMouse)
        {
            TapMouse = tapMouse;
            TapKeyboard = tapKeyboard;
        }

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
