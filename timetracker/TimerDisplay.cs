﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using timetracker.Models;
using timetracker.Services;
using timetracker.Structs;

namespace timetracker
{
    public partial class TimerDisplay : Form
    {
        Project selectedProject = null;
        WorkType selectedWorkType = null;
        Work selectedWork = null;

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
                lbTime.Text = Services.Timer.FormatTime(e.Count);
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
            if(selectedWork.Id == 0)
            {
                string comment = Prompt.ShowDialog("Specify new work name", "New work");
                if (comment == null) return;
                selectedWork.UserId = Auth.CurrentUser.Id;
                selectedWork.Project = selectedProject;
                selectedWork.WorkType = selectedWorkType;
                selectedWork.Comment = comment;
                selectedWork.Save();
                RefreshWorks();
            }
            TimerManager.Instance.Start(selectedWork);
            SetEditControlsEnabled(false);
        }

        private void btResume_Click(object sender, EventArgs e)
        {
            TimerManager.Instance.Resume(selectedWork);
            SetEditControlsEnabled(false);
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            TimerManager.Instance.Stop();
            SetEditControlsEnabled(true);
            RefreshWorks();
        }

        /// <summary>
        /// Reload the list of Works preserving currently selected item
        /// </summary>
        private void RefreshWorks() {
            int selectedId = selectedWork?.Id ?? 0;
            cbWorks.DataSource = WorkModel.ListWithBlank("--- New work ---", Auth.CurrentUser);
            for (int pos = 0; pos< cbWorks.Items.Count; pos++)
            {
                if (((Work)cbWorks.Items[pos]).Id == selectedId)
                {
                    cbWorks.SelectedIndex = pos;
                    break;
                }
            }
        }

        private void SetEditControlsEnabled(bool enabled)
        {
            cbProjects.Enabled = enabled;
            cbWorkTypes.Enabled = enabled;
            cbWorks.Enabled = enabled;
        }

        private void TimerDisplay_Load(object sender, EventArgs e)
        {
            UpdateLists();
            lbGreeting.Text = "Hi " + Auth.CurrentUser.FullName;
        }

        private void UpdateLists() {
            cbProjects.DataSource = ProjectModel.List();
            cbWorkTypes.DataSource = WorkTypeModel.List();
            RefreshWorks();
        }

        private void cbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProject = (Project)cbProjects.SelectedItem;
        }

        private void cbWorkTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWorkType = (WorkType)cbWorkTypes.SelectedItem;
        }

        private void cbWorks_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWork = (Work)cbWorks.SelectedItem;
            _ShowCurrentWorkData();
            
            btStart.Enabled = selectedWork.Id == 0;
            btResume.Enabled = selectedWork.Id != 0;
        }

        private void _ShowCurrentWorkData() {
            lbTime.Text = Services.Timer.FormatTime(selectedWork.Time);

            if (selectedWork.Id == 0)
            {
                // enable work properties if this is a new work
                cbProjects.Enabled = true;
                cbWorkTypes.Enabled = true;
                btEditWork.Enabled = false;
            }
            else
            {
                // allow in-place editing of existing work
                btEditWork.Enabled = true;
                // if existing work - disable comboboxes and set appropriate values there 
                // to reflect current work's settings
                cbProjects.Enabled = false;
                for (int i = 0; i < cbProjects.Items.Count; i++)
                {
                    if (((Project)cbProjects.Items[i]).Id == selectedWork.ProjectId)
                    {
                        cbProjects.SelectedIndex = i;
                        break;
                    }
                }

                cbWorkTypes.Enabled = false;
                for (int i = 0; i < cbWorkTypes.Items.Count; i++)
                {
                    if (((WorkType)cbWorkTypes.Items[i]).Id == selectedWork.WorkTypeId)
                    {
                        cbWorkTypes.SelectedIndex = i;
                        break;
                    }
                }

            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private bool EditMode = false;

        private void btEditWork_Click(object sender, EventArgs e) => EditModeStart();
        
        private void EditModeStart()
        {
            EditMode = true;
            panTimeControl.Enabled = false;
            panEditName.Enabled = true;
            panEditName.Visible = true;
            cbProjects.Enabled = true;
            cbWorkTypes.Enabled = true;
            tbWorkName.Text = selectedWork.Comment;
            tbWorkName.Focus();
        }
        private void EditModeSave() {
            selectedWork.Project = selectedProject;
            selectedWork.WorkType = selectedWorkType;
            selectedWork.Comment = tbWorkName.Text;
            selectedWork.Save();
            _EditModeStop();
            RefreshWorks();
        }
        private void EditModeCancel() => _EditModeStop();

        private void _EditModeStop()
        {
            EditMode = false;
            panTimeControl.Enabled = true;
            panEditName.Enabled = false;
            panEditName.Visible = false;
            cbProjects.Enabled = false;
            cbWorkTypes.Enabled = false;
            _ShowCurrentWorkData();
        }

        private void btEditWorkSave_Click(object sender, EventArgs e) => EditModeSave();

        private void btEditWorkNoSave_Click(object sender, EventArgs e) => EditModeCancel();

        private void TimerDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Escape)
            {
                if (EditMode) EditModeCancel();
                else { Visible = false; }
            }

            if (e.KeyChar == (int)Keys.Enter)
            {
                if (EditMode) EditModeSave();
            }
        }
    }
}
