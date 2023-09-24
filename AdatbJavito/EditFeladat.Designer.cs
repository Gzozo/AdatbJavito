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
            FeladatSzam = new NumericUpDown();
            panel1 = new Panel();
            testfeladatuc = new FeladatUC();
            jegyHatar2 = new JegyHatar();
            jegyHatar3 = new JegyHatar();
            jegyHatar4 = new JegyHatar();
            jegyHatar5 = new JegyHatar();
            jegyHatarImsc = new JegyHatar();
            samplesComboBox = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)FeladatSzam).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // FeladatSzam
            // 
            FeladatSzam.Location = new Point(602, 99);
            FeladatSzam.Name = "FeladatSzam";
            FeladatSzam.Size = new Size(39, 23);
            FeladatSzam.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(testfeladatuc);
            panel1.Location = new Point(12, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 342);
            panel1.TabIndex = 1;
            // 
            // testfeladatuc
            // 
            testfeladatuc.Location = new Point(6, 3);
            testfeladatuc.Name = "testfeladatuc";
            testfeladatuc.Size = new Size(575, 32);
            testfeladatuc.TabIndex = 0;
            // 
            // jegyHatar2
            // 
            jegyHatar2.AutoSize = true;
            jegyHatar2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            jegyHatar2.Grade = "2";
            jegyHatar2.Location = new Point(218, 25);
            jegyHatar2.Name = "jegyHatar2";
            jegyHatar2.Points = 0.11D;
            jegyHatar2.Size = new Size(83, 53);
            jegyHatar2.TabIndex = 2;
            // 
            // jegyHatar3
            // 
            jegyHatar3.AutoSize = true;
            jegyHatar3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            jegyHatar3.Grade = "3";
            jegyHatar3.Location = new Point(307, 25);
            jegyHatar3.Name = "jegyHatar3";
            jegyHatar3.Points = 0.1D;
            jegyHatar3.Size = new Size(83, 53);
            jegyHatar3.TabIndex = 2;
            // 
            // jegyHatar4
            // 
            jegyHatar4.AutoSize = true;
            jegyHatar4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            jegyHatar4.Grade = "4";
            jegyHatar4.Location = new Point(396, 25);
            jegyHatar4.Name = "jegyHatar4";
            jegyHatar4.Points = 0D;
            jegyHatar4.Size = new Size(83, 53);
            jegyHatar4.TabIndex = 2;
            // 
            // jegyHatar5
            // 
            jegyHatar5.AutoSize = true;
            jegyHatar5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            jegyHatar5.Grade = "5";
            jegyHatar5.Location = new Point(485, 25);
            jegyHatar5.Name = "jegyHatar5";
            jegyHatar5.Points = 10D;
            jegyHatar5.Size = new Size(83, 53);
            jegyHatar5.TabIndex = 2;
            // 
            // jegyHatarImsc
            // 
            jegyHatarImsc.AutoSize = true;
            jegyHatarImsc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            jegyHatarImsc.Grade = "Imsc";
            jegyHatarImsc.Location = new Point(574, 25);
            jegyHatarImsc.Name = "jegyHatarImsc";
            jegyHatarImsc.Points = 10D;
            jegyHatarImsc.Size = new Size(83, 53);
            jegyHatarImsc.TabIndex = 2;
            // 
            // samplesComboBox
            // 
            samplesComboBox.FormattingEnabled = true;
            samplesComboBox.Location = new Point(91, 38);
            samplesComboBox.Name = "samplesComboBox";
            samplesComboBox.Size = new Size(121, 23);
            samplesComboBox.TabIndex = 3;
            samplesComboBox.SelectedIndexChanged += samplesComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 41);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "Samples: ";
            // 
            // EditFeladat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 450);
            Controls.Add(label1);
            Controls.Add(samplesComboBox);
            Controls.Add(jegyHatarImsc);
            Controls.Add(jegyHatar5);
            Controls.Add(jegyHatar4);
            Controls.Add(jegyHatar3);
            Controls.Add(jegyHatar2);
            Controls.Add(panel1);
            Controls.Add(FeladatSzam);
            DoubleBuffered = true;
            Name = "EditFeladat";
            Text = "EditFeladat";
            FormClosing += EditFeladat_FormClosing;
            ((System.ComponentModel.ISupportInitialize)FeladatSzam).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox samplesComboBox;
        private Label label1;
    }
}