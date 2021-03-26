using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kohonena.Krasivosti
{
    public partial class ConsForHack3 : Form
    {
        string[] kod = "\n░░░░░░░░░░░░░░░░\n░░▓▓▓░░░░░▓▓▓░░░\n░░▓▓▓░░░░░▓▓▓░░░\n░▓▓▓▓▓░░░▓▓▓▓▓░░\n░▓▓▓▓▓░░░▓▓▓▓▓░░\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-\n░░░░░░░░░░░░░░░░\n░▓▓▓░░░░░▓▓▓░░░░\n░▓▓▓░░░░░▓▓▓░░░░\n▓▓▓▓▓░░░▓▓▓▓▓░░░\n▓▓▓▓▓░░░▓▓▓▓▓░░░\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-\n░░░░░░░░░░░░░░░░\n▓▓▓░░░░░▓▓▓░░░░░\n▓▓▓░░░░░▓▓▓░░░░░\n▓▓▓▓░░░▓▓▓▓▓░░░▓\n▓▓▓▓░░░▓▓▓▓▓░░░▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-\n░░░░░░░░░░░░░░░░\n▓▓░░░░░▓▓▓░░░░░▓\n▓▓░░░░░▓▓▓░░░░░▓\n▓▓▓░░░▓▓▓▓▓░░░▓▓\n▓▓▓░░░▓▓▓▓▓░░░▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-\n░░░░░░░░░░░░░░░░\n▓░░░░░▓▓▓░░░░░▓▓\n▓░░░░░▓▓▓░░░░░▓▓\n▓▓░░░▓▓▓▓▓░░░▓▓▓\n▓▓░░░▓▓▓▓▓░░░▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-\n░░░░░░░░░░░░░░░░\n░░░░░▓▓▓░░░░░▓▓▓\n░░░░░▓▓▓░░░░░▓▓▓\n▓░░░▓▓▓▓▓░░░▓▓▓▓\n▓░░░▓▓▓▓▓░░░▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-\n░░░░░░░░░░░░░░░░\n░░░░▓▓▓░░░░░▓▓▓░\n░░░░▓▓▓░░░░░▓▓▓░\n░░░▓▓▓▓▓░░░▓▓▓▓▓\n░░░▓▓▓▓▓░░░▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-\n░░░░░░░░░░░░░░░░\n░░░▓▓▓░░░░░▓▓▓░░\n░░░▓▓▓░░░░░▓▓▓░░\n░░▓▓▓▓▓░░░▓▓▓▓▓░\n░░▓▓▓▓▓░░░▓▓▓▓▓░\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n".Split('-');
        int i = 0;

        public ConsForHack3()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = this.label2.Text = this.COD.Text = kod[i];
            
            if (i + 1 < kod.Length)
            {
                i ++;
            }
            else {
                i = 0;
            }
        }
    }
}
