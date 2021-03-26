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
    public partial class Dobavlenie : Form
    {
        Form1 forma;
        public Dobavlenie(Form1 fo)
        {
            InitializeComponent();
            this.forma = fo;
        }

        private void AddColor_Click(object sender, EventArgs e)
        {
            if (CoDi.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                forma.AddColorOblast(CoDi.Color);
                System.Windows.Forms.Panel pa = new System.Windows.Forms.Panel();
                pa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pa.Location = new System.Drawing.Point(0, 40 * ColPan.Count());
                pa.BackColor = CoDi.Color;
                pa.Name = "ColPan";
                pa.Size = new System.Drawing.Size(123, 40);
                pa.TabIndex = 0;
                this.ColPan.Add(pa);
                this.panel1.Controls.Add(pa);
            }
        }

        private void OkColor_Click(object sender, EventArgs e)
        {
            forma.VideleniePobediteley();
            this.Close();
        }

    }
}
