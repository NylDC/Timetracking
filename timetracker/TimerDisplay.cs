using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using timetracker.Services;

namespace timetracker
{
    public partial class TimerDisplay : Form
    {
        public TimerDisplay()
        {
            InitializeComponent();
            Services.Timer.Instance.CounterChange += CounterChanged;
            Services.Timer.Instance.TimerStart += CounterStarted;
            Services.Timer.Instance.TimerStop += CounterStopped;
            Services.Timer.Instance.TimerResume += CounterResumed;
        }
        

        public void CounterChanged(object sender, TimerEventArgs e)
        {
            Invoke(new Action(() =>
            {
                lbTime.Text = String.Format("{0:00}:{1:00}:{2:00}", e.Hours, e.Minutes, e.Seconds);
            }));
        }

        public void CounterStarted(object sender, TimerEventArgs e)
        {
            btStart.Enabled = false;
            btResume.Enabled = false;
            btStop.Enabled = true;
        }

        public void CounterStopped(object sender, TimerEventArgs e)
        {
            btStart.Enabled = true;
            btResume.Enabled = true;
            btStop.Enabled = false;
        }

        public void CounterResumed(object sender, TimerEventArgs e)
        {
            btStart.Enabled = false;
            btResume.Enabled = false;
            btStop.Enabled = true;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            // TODO: Take this from a real DB
            Structs.Project project = new Structs.Project();
            Structs.WorkType workType = new Structs.WorkType();
            Structs.Work work = new Structs.Work();
            TimerManager.Instance.Start(project, workType, work);
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            TimerManager.Instance.Resume();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            TimerManager.Instance.Stop();
        }
    }
}
