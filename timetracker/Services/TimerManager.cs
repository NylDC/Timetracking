using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timetracker.Structs;
using timetracker.Advisors;

namespace timetracker.Services
{
    /// <summary>
    /// Singleton class to be used to control the Timer.
    /// </summary>
    class TimerManager
    {
        private static TimerManager _instance = null;

        public static TimerManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TimerManager();
                }
                return _instance;
            }
        }

        private Project currentProject;
        private WorkType currentWorkType;
        private Work currentWork;

        /// <summary>
        /// Constructor.
        /// Binds timer events
        /// </summary>
        public TimerManager() {
            Timer.Instance.CounterChange += OnCounterChange;
        }

        public void Start(Project project, WorkType workType, Work work)
        {
            StopEverything();

            currentProject = project;
            currentWorkType = workType;
            currentWork = work;

            StartEverything();
        }

        public void Stop() => StopEverything();

        private void StartEverything()
        {
            Timer.Instance.Value = currentWork.Time; // Allow resuming of the task
            Timer.Instance.Resume();

            if (currentProject.MakeScreenshots)
            {
                Screenshots.Instance.Start();
            }
            if (currentProject.CheckKeyboard || currentProject.CheckMouse)
            {
                Timer.Advisors.Add(new TapUserInput(currentProject.CheckKeyboard, currentProject.CheckMouse));
            }
            if (currentProject.CheckWebsites)
            {
                Timer.Advisors.Add(new TapBrowsers());
            }
            if (currentProject.CheckApps)
            {
                Timer.Advisors.Add(new TapProcesses());
            }
        }

        private void StopEverything()
        {
            Timer.Instance.Stop();
            Timer.Advisors.Clear(); // Delete all checkers
            Screenshots.Instance.Stop();
        }
        
        /// <summary>
        /// Adds time to the work's total time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCounterChange(object sender, TimerEventArgs e)
        {
            //TODO: Add time to the 
            currentWork.Time = e.Count;
        }
    }
}
