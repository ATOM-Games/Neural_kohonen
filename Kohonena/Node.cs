using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kohonena
{
    public partial class Node : UserControl
    {
        double myForstR, myForstG, myForstB;
        public bool Obutchen = false;
        public Node()
        {
            //InitializeComponent();
        }
        public Node(int newx, int newy)
        {
            //InitializeComponent();
        }
        public Node(int newx, int newy, Color newMyCol)
        {
            InitializeComponent(newx, newy, newMyCol);
            myForstR = (newMyCol.R * 1f) / 255;
            myForstG = (newMyCol.G * 1f) / 255;
            myForstB = (newMyCol.B * 1f) / 255;
        }
        public int GetX() { return this.Location.X / 20; }
        public int GetY() { return this.Location.Y / 20; }
        public string ToStringColor() {
            return "[ r(" + this.BackColor.R + ") g(" + this.BackColor.G + ") b(" + this.BackColor.B + ") ]";
        }
        //rgb getters 0-255 to 0-1
        public double GetR_onew() { return (this.BackColor.R * 1f) / 255; }
        public double GetG_onew() { return (this.BackColor.G * 1f) / 255; }
        public double GetB_onew() { return (this.BackColor.B * 1f) / 255; }

        public double GetR_fonew() { return this.myForstR; }
        public double GetG_fonew() { return this.myForstG; }
        public double GetB_fonew() { return this.myForstB; }

        //rgb setters 0-255 to 0-1

        public void SetCol_onew(double Rr, double Gg, double Bb) {
            int rrr = (((int)(Rr * 255)) > 255) ? 255 : ((int)(Rr * 255));
            int bbb = (((int)(Bb * 255)) > 255) ? 255 : ((int)(Bb * 255));
            int ggg = (((int)(Gg * 255)) > 255) ? 255 : ((int)(Gg * 255));
            this.BackColor = Color.FromArgb(rrr, ggg, bbb);
        }



    }
}
