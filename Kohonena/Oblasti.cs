using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kohonena
{
    class Oblasti
    {
        public System.Drawing.Color Ideal, Centr;
        public int X, Y;

        public Oblasti(System.Drawing.Color id) {
            this.Ideal = id;
        }

        public Oblasti (int x, int y, System.Drawing.Color id, System.Drawing.Color cen){
            this.X = x; this.Y = y;
            this.Ideal = id; this.Centr = cen;
        }

        public bool Raven(int x, int y) { return (this.X==x && this.Y==y); }
    }
}
