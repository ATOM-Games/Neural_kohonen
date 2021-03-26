using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kohonena
{
    public partial class Iteracii : Form
    {
        Form1 fml;

        public Iteracii(Form1 d)
        {
            InitializeComponent();
            this.fml = d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fml.Obutchi(fml.GetIte()+Int32.Parse(numericUpDown1.Value+""));
        }
    }
}
