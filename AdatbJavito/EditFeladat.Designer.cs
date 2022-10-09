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
            this.panel1.Location = new System.Drawing.Point(71, 96);
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
            // EditFeladat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FeladatSzam);
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
    }
}