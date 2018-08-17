using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using timetracker.Structs;

namespace timetracker
{
    
    public partial class SplashForm : Form
    {
        List<Citation> citations;
        public SplashForm()
        {
            InitializeComponent();
            citations = new List<Citation> {
                new Citation("Aretha Franklin","It might be one o'clock, and it might be three. I don't care, 'cause time means nothin' to me."),
                new Citation("Aretha Franklin","I see that clock upon the wall. Well it don’t bother me at all."),
                new Citation("Gray Scott","Robots will harvest, cook, and serve our food. They will work in our factories, drive our cars, and walk our dogs. Like it or not, the age of work is coming to an end."),
                new Citation("Warren Buffett","Someone is sitting in the shade today because someone planted a tree a long time ago."),
                new Citation("Leo Tolstoy","The two most powerful warriors are patience and time."),
            };
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int pos = random.Next(citations.Count);
            Citation picked = citations[pos];
            lbName.Text = picked.Author;
            lbQuote.Text = picked.Words;

            Left = (Screen.PrimaryScreen.WorkingArea.Width - Size.Width)/2;
            Top = (Screen.PrimaryScreen.WorkingArea.Height - Size.Height)/2;
        }

        private void SplashForm_Shown(object sender, EventArgs e)
        {
            hideSplashTimer.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Visible = false;
            hideSplashTimer.Enabled = false;
        }
    }
}
