using System.Collections.Generic;
namespace Kohonena
{
    partial class Dobavlenie
    {
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
            this.AddColor = new System.Windows.Forms.Button();
            this.OkBut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CoDi = new System.Windows.Forms.ColorDialog();
            this.ColPan = new List<System.Windows.Forms.Panel>();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddColor
            // 
            this.AddColor.Location = new System.Drawing.Point(135, 12);
            this.AddColor.Name = "AddColor";
            this.AddColor.Size = new System.Drawing.Size(75, 39);
            this.AddColor.TabIndex = 0;
            this.AddColor.Text = "Добаить цвет";
            this.AddColor.UseVisualStyleBackColor = true;
            this.AddColor.Click += new System.EventHandler(this.AddColor_Click);

            this.OkBut.Location = new System.Drawing.Point(135, 52);
            this.OkBut.Name = "AddColor";
            this.OkBut.Size = new System.Drawing.Size(75, 39);
            this.OkBut.TabIndex = 0;
            this.OkBut.Text = "OK";
            this.OkBut.UseVisualStyleBackColor = true;
            this.OkBut.Click += new System.EventHandler(this.OkColor_Click);

            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 223);
            this.panel1.TabIndex = 1;
            // 
            // ColPan
            // 
            
            // 
            // Dobavlenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 224);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddColor);
            this.Controls.Add(this.OkBut);
            this.Name = "Dobavlenie";
            this.Text = "Dobavlenie";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddColor, OkBut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog CoDi;
        private List<System.Windows.Forms.Panel> ColPan;
    }
}