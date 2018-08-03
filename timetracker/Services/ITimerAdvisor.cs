using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timetracker.Services
{
    /// <summary>
    /// Interface for Advisor object that is mean to tell the Timer if it should count time
    /// at any given time.
    /// </summary>
    public interface ITimerAdvisor
    {
        /// <summary>
        /// Must report if the instance of the implementer class considers current user 
        /// activity legitimate for the Timer.
        /// </summary>
        /// <returns>To count last second or not.</returns>
        bool AdviseIfCanCount();

        /// <summary>
        /// Called when timer is started.
        /// </summary>
        void OnTimerStart();

        /// <summary>
        /// Called when timer is stopped. Must free all own resources.
        /// After this method's call ITimerAdvisor object will not be used any more and is a subject to destruction.
        /// </summary>
        void OnTimerStop();
    }
}
