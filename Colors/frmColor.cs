using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colors
{
    public partial class frmColor : Form
    {

        public frmColor()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await changeColor();
        }

        private async Task changeColor()
        {
            Random rand = new Random();
            Color color = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            this.BackColor = color;
        }
    }
}
