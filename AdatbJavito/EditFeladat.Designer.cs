namespace AdatbJavito
{
    partial class EditFeladat
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
            this.FeladatSzam = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.testfeladatuc = new AdatbJavito.FeladatUC();
            this.jegyHatar2 = new AdatbJavito.JegyHatar();
            this.jegyHatar3 = new AdatbJavito.JegyHatar();
            this.jegyHatar4 = new AdatbJavito.JegyHatar();
            this.jegyHatar5 = new AdatbJavito.JegyHatar();
            this.jegyHatarImsc = new AdatbJavito.JegyHatar();
            ((System.ComponentModel.ISupportInitialize)(this.FeladatSzam)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FeladatSzam
            // 
            this.FeladatSzam.Location = new System.Drawing.Point(128, 37);
            this.FeladatSzam.Name = "FeladatSzam";
            this.FeladatSzam.Size = new System.Drawing.Size(39, 23);
            this.FeladatSzam.TabIndex = 0;
            this.FeladatSzam.ValueChanged += new System.EventHandler(this.FeladatSzam_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.testfeladatuc);
            this.panel1.Location = new System.Drawing.Point(12, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 342);
            this.panel1.TabIndex = 1;
            // 
            // testfeladatuc
            // 
            this.testfeladatuc.Location = new System.Drawing.Point(6, 3);
            this.testfeladatuc.Name = "testfeladatuc";
            this.testfeladatuc.Size = new System.Drawing.Size(575, 32);
            this.testfeladatuc.TabIndex = 0;
            // 
            // jegyHatar2
            // 
            this.jegyHatar2.AutoSize = true;
            this.jegyHatar2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jegyHatar2.Grade = "2";
            this.jegyHatar2.Location = new System.Drawing.Point(218, 25);
            this.jegyHatar2.Name = "jegyHatar2";
            this.jegyHatar2.Points = 0.11D;
            this.jegyHatar2.Size = new System.Drawing.Size(83, 53);
            this.jegyHatar2.TabIndex = 2;
            // 
            // jegyHatar3
            // 
            this.jegyHatar3.AutoSize = true;
            this.jegyHatar3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jegyHatar3.Grade = "3";
            this.jegyHatar3.Location = new System.Drawing.Point(307, 25);
            this.jegyHatar3.Name = "jegyHatar3";
            this.jegyHatar3.Points = 0.1D;
            this.jegyHatar3.Size = new System.Drawing.Size(83, 53);
            this.jegyHatar3.TabIndex = 2;
            // 
            // jegyHatar4
            // 
            this.jegyHatar4.AutoSize = true;
            this.jegyHatar4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jegyHatar4.Grade = "4";
            this.jegyHatar4.Location = new System.Drawing.Point(396, 25);
            this.jegyHatar4.Name = "jegyHatar4";
            this.jegyHatar4.Points = 0D;
            this.jegyHatar4.Size = new System.Drawing.Size(83, 53);
            this.jegyHatar4.TabIndex = 2;
            // 
            // jegyHatar5
            // 
            this.jegyHatar5.AutoSize = true;
            this.jegyHatar5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jegyHatar5.Grade = "5";
            this.jegyHatar5.Location = new System.Drawing.Point(485, 25);
            this.jegyHatar5.Name = "jegyHatar5";
            this.jegyHatar5.Points = 10D;
            this.jegyHatar5.Size = new System.Drawing.Size(83, 53);
            this.jegyHatar5.TabIndex = 2;
            // 
            // jegyHatarImsc
            // 
            this.jegyHatarImsc.AutoSize = true;
            this.jegyHatarImsc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jegyHatarImsc.Grade = "Imsc";
            this.jegyHatarImsc.Location = new System.Drawing.Point(574, 25);
            this.jegyHatarImsc.Name = "jegyHatarImsc";
            this.jegyHatarImsc.Points = 10D;
            this.jegyHatarImsc.Size = new System.Drawing.Size(83, 53);
            this.jegyHatarImsc.TabIndex = 2;
            // 
            // EditFeladat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.jegyHatarImsc);
            this.Controls.Add(this.jegyHatar5);
            this.Controls.Add(this.jegyHatar4);
            this.Controls.Add(this.jegyHatar3);
            this.Controls.Add(this.jegyHatar2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FeladatSzam);
            this.DoubleBuffered = true;
            this.Name = "EditFeladat";
            this.Text = "EditFeladat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditFeladat_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.FeladatSzam)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown FeladatSzam;
        private Panel panel1;
        private FeladatUC testfeladatuc;
        private JegyHatar jegyHatar2;
        private JegyHatar jegyHatar3;
        private JegyHatar jegyHatar4;
        private JegyHatar jegyHatar5;
        private JegyHatar jegyHatarImsc;
    }
}