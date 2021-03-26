using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Kohonena
{
    class ABC_lob
    {
        static public double DeltaColor(System.Drawing.Color Ideal, System.Drawing.Color NeIdeal) {
            return Math.Sqrt(((Ideal.R - NeIdeal.R) * (Ideal.R - NeIdeal.R)) + ((Ideal.G - NeIdeal.G) * ((Ideal.G - NeIdeal.G)) + ((Ideal.B - NeIdeal.B) *(Ideal.B - NeIdeal.B)))); 
        }

        static public double DeltaNote(Node Pod, Node NePod) { // RASSTOANIE
            return Math.Sqrt(((Pod.GetX() - NePod.GetX()) * (Pod.GetX() - NePod.GetX())) + ((Pod.GetY() - NePod.GetY()) * (Pod.GetY() - NePod.GetY())));
        }

        static double Q_0 = 200;

        static public double Lambda(int t) {
            return (t*1d) / Math.Log(Q_0*0.075d);  // T/log(Q_0) Q_0 = max(W, H)/2 W=20*20 H=20*20 = 400/2 = 200  Q_0 = 200
        }

        static public double Q_t(int t) {
            return Q_0 * Math.Exp(-(t*1d) / Lambda(t));
        }

        static public bool IsSosed(Node Pod, Node NePod, int T) {
            return (DeltaNote(Pod, NePod) < Q_t(T));
        }

        static public double Vlianie(Node Pod, Node NePod, int T) {
            return Math.Exp(-1 * ((DeltaNote(Pod, NePod) * DeltaNote(Pod, NePod)) / (2 * Q_t(T) * Q_t(T))) );
        }


        static public void Obuchenie (Node Ideal, ref Node  neIdeal, int T, Color neww) {
            double rr = neIdeal.GetR_onew();
            double gg = neIdeal.GetG_onew();
            double bb = neIdeal.GetB_onew();

            double tetha = Math.Exp((-DeltaNote(Ideal, neIdeal) * DeltaNote(Ideal, neIdeal)) / (2 * Q_t(T) * Q_t(T)));
            /*
            double newrrr = rr + tetha * Vlianie(Ideal, neIdeal, T) * ((neww.R * 1d) / 255d - rr);
            double newggg = gg + tetha * Vlianie(Ideal, neIdeal, T) * ((neww.G * 1d) / 255d - gg);
            double newbbb = bb + tetha * Vlianie(Ideal, neIdeal, T) * ((neww.B * 1d) / 255d - bb);
            */
            double newrrr = rr + tetha * Vlianie(Ideal, neIdeal, T) * ((neww.R * 1d) / 255d - rr);
            double newggg = gg + tetha * Vlianie(Ideal, neIdeal, T) * ((neww.G * 1d) / 255d - gg);
            double newbbb = bb + tetha * Vlianie(Ideal, neIdeal, T) * ((neww.B * 1d) / 255d - bb);
            neIdeal.SetCol_onew(newrrr, newggg, newbbb);
            /* 
             neIdeal.SetCol_onew( ((rr * Ideal.GetR_onew()) * Vlianie(Ideal, neIdeal, T)),
                ((gg * Ideal.GetG_onew()) * Vlianie(Ideal, neIdeal, T)),
                ((bb * Ideal.GetB_onew()) * Vlianie(Ideal, neIdeal, T)));
              
             neIdeal.SetCol_onew((rr * Ideal.GetR_onew() ),
                (gg * Ideal.GetG_onew() ),
                (bb * Ideal.GetB_onew() ));
              
             */
        }

    }
}
