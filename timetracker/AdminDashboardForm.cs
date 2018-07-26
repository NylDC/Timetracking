using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetracker
{
	public partial class AdminDashboardForm : Form
	{
		public AdminDashboardForm()
		{
			InitializeComponent();
			tbFreq.Text = Configuration.ScreenshottingFrequency.ToString();
		}

		private void btOK_Click(object sender, EventArgs e)
		{
			Configuration.ScreenshottingFrequency = Int32.Parse(tbFreq.Text);
		}
	}
}
