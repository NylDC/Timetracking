using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using timetracker.Services;

namespace timetracker
{
	public partial class EmployeeLogin : Form
	{
		public EmployeeLogin()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btLogin_Click(object sender, EventArgs e)
		{

			if (Auth.Authenticate(tbLogin.Text, tbPassword.Text) != null)
			{
				this.Hide();
				btLogin.Show();
				MessageBox.Show("Hi "+ Auth.CurrentUser.FullName, "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				MessageBox.Show("Please enter a valid username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
	
			
		

	

