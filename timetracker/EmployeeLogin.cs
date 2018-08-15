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

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nyl\Documents\Authentication.mdf;Integrated Security=True;Connect Timeout=30");
			SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", connection);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			if (dt.Rows[0][0].ToString() == "1")
			{
				this.Hide();
				Main login = new Main();
				login.Show();
			}
			else
			{
				MessageBox.Show("Please enter a valid username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
	
			
		

	

