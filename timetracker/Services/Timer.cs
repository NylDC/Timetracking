using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;

namespace timetracker.Services
{
    /// <summary>
    /// Singleton class provides separate thread to count seconds.
    /// Attach events to CounterChange Event to react to changes.
    /// </summary>
    class Timer
    {
        private static Timer _instance = null;

        /// <summary>
        /// Loop function container.
        /// </summary>
        private ThreadStart threadStart;

        /// <summary>
        /// Timer thread instance.
        /// </summary>
        private Thread childThread;

        /// <summary>
        /// Indicates if we timer should advance every second.
        /// Must be manipulated externally by different checkers.
        /// </summary>
        private bool DoCount = true;

        /// <summary>
        /// Provides Singleton interface for the Timer class.
        /// </summary>
        public static Timer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Timer();
                }
                return _instance;
            }
        }

        public Timer()
        {
            threadStart = new ThreadStart(Loop);
        }

        ~Timer()
        {
            Stop();
        }

        /// <summary>
        /// If Timer is stopped Starts timer and resets the Value.
        /// See Resume() to start without value reset.
        /// </summary>
        public void Start()
        {
            if (childThread == null || !childThread.IsAlive)
            {
                Value = 0;
                childThread = new Thread(threadStart);
                childThread.Start();
                OnStart(new TimerEventArgs(Value));
            }
        }

        /// <summary>
        /// Starts timer if not started yet and does not reset the Value.
        /// See Start() to start with value reset.
        /// </summary>
        public void Resume()
        {
            if (childThread == null || !childThread.IsAlive)
            {
                childThread = new Thread(threadStart);
                childThread.Start();
                OnResume(new TimerEventArgs(Value));
            }
        }

        /// <summary>
        /// Stops the timer.
        /// </summary>
        public void Stop()
        {
            if (childThread.IsAlive)
            {
                childThread.Abort();
                OnStop(new TimerEventArgs(Value));
                // TODO: Commit result.
            }
        }

        /// <summary>
        /// Internal counter. Use Value for interaction.
        /// </summary>
        private int _value;

        /// <summary>
        /// Private function to control the value change.
        /// Getter returns internal counter.
        /// Setter Triggers OnCount() event.
        /// </summary>
        private int Value {
            get {
                return _value;
            }
            set
            {
                _value = value;
                OnCount(new TimerEventArgs(_value));
            }
        }

        /// <summary>
        /// Return currently calculated time in seconds.
        /// </summary>
        /// <returns>
        /// The number of pure seconds
        /// </returns>
        public int GetValue()
        {
            return Value;
        }

        /// <summary>
        /// The body of the timer thread thet is nvoked by Start/Resume/Stop.
        /// Tries to advance counter every second.
        /// </summary>
        private void Loop()
        {
            while (true)
            {
                Thread.Sleep(1000);
                TryAdvanceCounter();
            }
        }

        /// <summary>
        /// Executed once per second if counter should be updated
        /// </summary>
        private void TryAdvanceCounter()
        {
            // add Second to the counter
            if (DoCount)
                Value += 1;
        }

        /// <summary>
        /// Distinctive event type for the EventHandlerList
        /// </summary>
        static readonly object countEventKey = new object();
        static readonly object timerStartEventKey = new object();
        static readonly object timerStopEventKey = new object();
        static readonly object timerResumeEventKey = new object();

        /// <summary>
        /// Container for event handlers
        /// </summary>
        protected EventHandlerList listEventDelegates = new EventHandlerList();

        /// <summary>
        /// Type for event handler to be used for subscribing to the Timer events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void CountEventHandler(object sender, TimerEventArgs e);

        public event CountEventHandler CounterChange
        {
            // Add the input delegate to the collection.
            add
            {
                listEventDelegates.AddHandler(countEventKey, value);
            }
            // Remove the input delegate from the collection.
            remove
            {
                listEventDelegates.RemoveHandler(countEventKey, value);
            }
        }

        public event CountEventHandler TimerStop
        {
            // Add the input delegate to the collection.
            add
            {
                listEventDelegates.AddHandler(timerStopEventKey, value);
            }
            // Remove the input delegate from the collection.
            remove
            {
                listEventDelegates.RemoveHandler(timerStopEventKey, value);
            }
        }

        public event CountEventHandler TimerStart
        {
            // Add the input delegate to the collection.
            add
            {
                listEventDelegates.AddHandler(timerStartEventKey, value);
            }
            // Remove the input delegate from the collection.
            remove
            {
                listEventDelegates.RemoveHandler(timerStartEventKey, value);
            }
        }

        public event CountEventHandler TimerResume
        {
            // Add the input delegate to the collection.
            add
            {
                listEventDelegates.AddHandler(timerResumeEventKey, value);
            }
            // Remove the input delegate from the collection.
            remove
            {
                listEventDelegates.RemoveHandler(timerResumeEventKey, value);
            }
        }

        /// <summary>
        /// Trigger CounterChange handlers
        /// </summary>
        /// <param name="e"></param>
        private void OnCount(TimerEventArgs e) => _runDelegateByType(e, countEventKey);

        /// <summary>
        /// Trigger TimerStart handlers
        /// </summary>
        /// <param name="e"></param>
        private void OnStart(TimerEventArgs e) => _runDelegateByType(e, timerStartEventKey);

        /// <summary>
        /// Trigger TimerStop handlers
        /// </summary>
        /// <param name="e"></param>
        private void OnStop(TimerEventArgs e) => _runDelegateByType(e, timerStopEventKey);

        /// <summary>
        /// Trigger TimerResume handlers
        /// </summary>
        /// <param name="e"></param>
        private void OnResume(TimerEventArgs e) => _runDelegateByType(e, timerResumeEventKey);
   
        /// <summary>
        /// Unified handler trigger used by other "On[Event]" functions
        /// </summary>
        /// <param name="e"></param>
        /// <param name="DelegateType"></param>
        private void _runDelegateByType(TimerEventArgs e, object DelegateType)
        {
            CountEventHandler eventDelegate =
                (CountEventHandler)listEventDelegates[DelegateType];
            eventDelegate(this, e);
        }
    }
}
