namespace Kohonena.Krasivosti
{
    partial class ConsForHack3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.COD = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // COD
            // 
            this.COD.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.COD.ForeColor = System.Drawing.Color.Red;
            this.COD.Location = new System.Drawing.Point(12, 9);
            this.COD.Name = "COD";
            this.COD.Size = new System.Drawing.Size(220, 131);
            this.COD.TabIndex = 0;
            this.COD.Text = "\r\n░░░░░░░░░░░░░░░░\r\n░░▓▓▓░░░░░▓▓▓░░░\r\n░░▓▓▓░░░░░▓▓▓░░░\r\n░▓▓▓▓▓░░░▓▓▓▓▓░░\r\n░▓▓▓▓▓░" +
                "░░▓▓▓▓▓░░\r\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\r\n";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 131);
            this.label1.TabIndex = 1;
            this.label1.Text = "\r\n░░░░░░░░░░░░░░░░\r\n░░▓▓▓░░░░░▓▓▓░░░\r\n░░▓▓▓░░░░░▓▓▓░░░\r\n░▓▓▓▓▓░░░▓▓▓▓▓░░\r\n░▓▓▓▓▓░" +
                "░░▓▓▓▓▓░░\r\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\r\n";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(431, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 131);
            this.label2.TabIndex = 2;
            this.label2.Text = "\r\n░░░░░░░░░░░░░░░░\r\n░░▓▓▓░░░░░▓▓▓░░░\r\n░░▓▓▓░░░░░▓▓▓░░░\r\n░▓▓▓▓▓░░░▓▓▓▓▓░░\r\n░▓▓▓▓▓░" +
                "░░▓▓▓▓▓░░\r\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\r\n";
            // 
            // ConsForHack3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(657, 140);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.COD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(500, 600);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsForHack3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ConsForHack";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label COD;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}