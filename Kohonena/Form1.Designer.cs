using System;
using System.Collections.Generic;
namespace Kohonena
{
    partial class Form1
    {
        Random randik = new Random();
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.Pole = new System.Windows.Forms.Panel();
            this.Button = new System.Windows.Forms.Button();
            this.Pole.SuspendLayout();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SuspendLayout();
            // 
            // Pole
            // 
            this.Pole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pole.Location = new System.Drawing.Point(12, 12);
            this.Pole.Name = "Pole";
            this.Pole.Size = new System.Drawing.Size(400, 400);
            this.Pole.TabIndex = 0;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(418, 12);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(308, 400);
            this.Button.TabIndex = 1;
            this.Button.Text = "Кластеризовать";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 124);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(299, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 495);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.Pole);
            this.Controls.Add(this.statusStrip1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Pole.ResumeLayout(false);
            this.ResumeLayout(false);
            this.NewRandomKlast();
        }

        #endregion

        private System.Windows.Forms.Panel Pole;
        private System.Windows.Forms.Button Button;
        private Node[][] Pixelki = new Node[20][];
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;


        public void NewRandomKlast() {
            this.Pole.Controls.Clear();
            this.Pixelki = new Node[20][];
            int i = 0;
            for (int y = 0; y < 20; y++)
            {
                Pixelki[y] = new Node[20];
                for (int x = 0; x < 20; x++)
                {

                    Pixelki[y][x] = new Node(x, y, System.Drawing.Color.FromArgb(randik.Next(1, 255), randik.Next(1, 255), randik.Next(1, 255)));
                    Pixelki[y][x].Location = new System.Drawing.Point(x * 20, y * 20);
                    Pixelki[y][x].BackColor = System.Drawing.Color.FromArgb(randik.Next(1, 255), randik.Next(1, 255), randik.Next(1, 255));
                    Pixelki[y][x].TabIndex = 0;
                    Pixelki[y][x].Name = "A";
                    this.Pole.Controls.Add(Pixelki[y][x]);
                    i++;
                }
            }
        }
    }
}

