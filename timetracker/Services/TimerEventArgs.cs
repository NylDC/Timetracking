using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timetracker.Services
{
    /// <summary>
    /// Contains number of seconds counted and provides calculation helpers for conversion. 
    /// </summary>
    class TimerEventArgs: EventArgs
    {
        /// <summary>
        /// Private field with the number of seconds counted
        /// </summary>
        private int _seconds = 0;

        /// <summary>
        /// Provides the total number of seconds. Readonly value. 
        /// </summary>   
        public int Count => _seconds;

        /// <summary>
        /// Contains seconds-only part of the total time counted.
        /// </summary>
        public int Seconds => _seconds%60;

        /// <summary>
        /// Contains minutes-only part of the total time counted.
        /// </summary>
        public int Minutes => _seconds / 60;

        /// <summary>
        /// Contains hours-only part of the total time counted.
        /// </summary>
        public int Hours => _seconds / 3600;

        /// <summary>
        /// Contains days-only part of the total time counted.
        /// </summary>
        public int Days => _seconds / 86400;

        public TimerEventArgs(int seconds)
        {
            _seconds = seconds;
        }
    }
}
