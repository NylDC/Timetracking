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
    public class TimerAdvisors : List<ITimerAdvisor>
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

        /// <summary>
        /// Stop all attached delegates by triggering their OnTimerStop()
        /// </summary>
        public void StopDelegates()
        {
            ForEach(delegate (ITimerAdvisor advisor)
            {
                advisor.OnTimerStop();
            });
        }

        /// <summary>
        /// Start all attached delegates by triggering their OnTimerStart()
        /// </summary>
        public void StartDelegates()
        {
            ForEach(delegate (ITimerAdvisor advisor)
            {
                advisor.OnTimerStart();
            });
        }
    }
}
