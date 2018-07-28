using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timetracker.Services
{
    /// <summary>
    /// Extension to a List&lt;ITimerAdvisor&gt; class 
    /// with special QueryDelegates() method to query all included delegates.
    /// </summary>
    class TimerAdvisors : List<ITimerAdvisor>
    {
        /// <summary>
        /// Queries all attached instances of ITimerAdvisor calling their AdviseIfCanCount() and
        /// reporting if all agree to allow time counting.
        /// </summary>
        /// <returns>bool value representing the decision</returns>
        public bool QueryDelegates()
        {
            bool retValue = true;
            ForEach(delegate (ITimerAdvisor advisor)
            {
                if(!advisor.AdviseIfCanCount())
                {
                    retValue = false;
                }
            });
            return retValue;
        }
    }
}
