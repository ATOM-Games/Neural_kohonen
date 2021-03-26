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
    public partial class Form1 : Form
    {

        List<Oblasti> Oblo = new List<Oblasti>();
        bool vis = true;
        int Iter = 1;




        public Form1()
        {
            InitializeComponent();
            /*
            Krasivosti.ConsForHack con = new Krasivosti.ConsForHack();
            con.Show();
            Krasivosti.ConsForHack2 con2 = new Krasivosti.ConsForHack2();
            con2.Show();
            Krasivosti.ConsForHack3 con3 = new Krasivosti.ConsForHack3();
            con3.Show();
            this.Oblo.Add(new Oblasti(0, 0, Color.Red, Color.Black));
            this.Oblo.Add(new Oblasti(0, 19, Color.Green, Color.Black));
            this.Oblo.Add(new Oblasti(19, 0, Color.Blue, Color.Black));
            this.Oblo.Add(new Oblasti(19, 19, Color.Yellow, Color.Black));
            */
        }

        private void Button_Click(object sender, EventArgs e) {
            Oblo.Clear();
            Dobavlenie dob = new Dobavlenie(this);
            dob.Show();
        }
        public void AddColorOblast(Color c){
            this.Oblo.Add( new Oblasti(c) );
        }

        public void VideleniePobediteley() {
            for (int y = 0; y < 20; y++) {
                for (int x = 0; x < 20; Pixelki[y][x].Visible=false, x++) ;
            }
            vis=false;
            //----------------------------------
            for (int po = 0; po < Oblo.Count(); po++ )
            {
                int Pobedx = -1, Pobedy = -1;
                double min = 99999999;
                for (int i = 0; i < Pixelki.Length; i++)
                {
                    for (int j = 0; j < Pixelki[i].Length; j++)
                    {
                        if (ABC_lob.DeltaColor(Oblo[po].Ideal, Pixelki[i][j].BackColor) < min)
                        {
                            min = ABC_lob.DeltaColor(Oblo[po].Ideal, Pixelki[i][j].BackColor);
                            Pobedx = i;
                            Pobedy = j;
                        }
                    }
                }
                if (Pobedx < 0 || Pobedy < 0) { MessageBox.Show("Победителя не оказалось"); }
                else {
                    Pixelki[Pobedx][Pobedy].Visible = true;
                    Oblo[po].Centr = Pixelki[Pobedx][Pobedy].BackColor;
                    Oblo[po].X = Pixelki[Pobedx][Pobedy].GetX();
                    Oblo[po].Y = Pixelki[Pobedx][Pobedy].GetY();
                }
            }
            Iteracii ne = new Iteracii(this);
            ne.Show();
        }

        public void Obutchi(int maxT) {
            if (!vis) {
                for (int y = 0; y < 20; y++) {
                    for (int x = 0; x < 20; Pixelki[y][x].Visible = true, x++) ;
                }
            }
            for (int Id = 0; Id < Oblo.Count(); Id++) {
                for (int y = 0; y < 20; y++) {
                    for (int x = 0; x < 20; x++) {
                        if (ABC_lob.IsSosed(Pixelki[Oblo[Id].Y][Oblo[Id].X], Pixelki[y][x], this.Iter))
                        {
                            ABC_lob.Obuchenie(Pixelki[Oblo[Id].Y][Oblo[Id].X], ref Pixelki[y][x], this.Iter, Oblo[Id].Ideal);
                            Pixelki[y][x].Obutchen = true;
                        }
                    }
                }
            }
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++) { if (!Pixelki[y][x].Obutchen) Pixelki[y][x].BackColor = Color.Black; }
            }
            this.toolStripStatusLabel1.Text = "[ "+this.Iter+" ]";
            this.Iter += 1;
            if (this.Iter < maxT)
            {
                Obutchi(maxT);
            }
        }

        public int GetIte() { return this.Iter; }
        public void SetIte(int T) { this.Iter = T; }


























        public void Klasterizovat() {
            int Pobedx = -1, Pobedy = -1;
            double min = 99999999;
            for (int i = 0; i < Pixelki.Length; i++)
            {
                for (int j = 0; j < Pixelki[i].Length; j++)
                {
                    if (ABC_lob.DeltaColor(Color.FromArgb(255, 0, 0), Pixelki[i][j].BackColor) < min)
                    {
                        min = ABC_lob.DeltaColor(Color.FromArgb(255, 0, 0), Pixelki[i][j].BackColor);
                        Pobedx = i;
                        Pobedy = j;
                    }
                }
            }
            if (Pobedx < 0 || Pobedy < 0) { MessageBox.Show("Победителя не оказалось"); }
            else
            {
                Pobeditel pod = new Pobeditel(Pixelki[Pobedx][Pobedy]);
                pod.Show();
            }
            //--------------------------------------------
            
        }

        public void Iteracii(int NumIt) {
        
        }
    }
}
