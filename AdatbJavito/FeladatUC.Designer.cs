namespace AdatbJavito
{
    partial class FeladatUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sorszam = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.TextBox();
            this.plusz = new System.Windows.Forms.TextBox();
            this.imsc = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.CheckBox();
            this.comment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sorszam
            // 
            this.sorszam.AutoSize = true;
            this.sorszam.Location = new System.Drawing.Point(5, 6);
            this.sorszam.Name = "sorszam";
            this.sorszam.Size = new System.Drawing.Size(53, 15);
            this.sorszam.TabIndex = 0;
            this.sorszam.Text = "X.feladat";
            // 
            // points
            // 
            this.points.Location = new System.Drawing.Point(64, 3);
            this.points.Name = "points";
            this.points.PlaceholderText = "0";
            this.points.Size = new System.Drawing.Size(48, 23);
            this.points.TabIndex = 1;
            this.points.Tag = "";
            this.points.DoubleClick += new System.EventHandler(this.Textbox_DoubleClick);
            // 
            // plusz
            // 
            this.plusz.Location = new System.Drawing.Point(118, 3);
            this.plusz.Name = "plusz";
            this.plusz.PlaceholderText = "0";
            this.plusz.Size = new System.Drawing.Size(48, 23);
            this.plusz.TabIndex = 1;
            this.plusz.Tag = "";
            this.plusz.DoubleClick += new System.EventHandler(this.Textbox_DoubleClick);
            // 
            // imsc
            // 
            this.imsc.Location = new System.Drawing.Point(172, 3);
            this.imsc.Name = "imsc";
            this.imsc.PlaceholderText = "0";
            this.imsc.Size = new System.Drawing.Size(48, 23);
            this.imsc.TabIndex = 1;
            this.imsc.Tag = "";
            this.imsc.DoubleClick += new System.EventHandler(this.Textbox_DoubleClick);
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(226, 7);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(15, 14);
            this.check.TabIndex = 2;
            this.check.UseVisualStyleBackColor = true;
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(247, 3);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(310, 23);
            this.comment.TabIndex = 3;
            // 
            // FeladatUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comment);
            this.Controls.Add(this.check);
            this.Controls.Add(this.imsc);
            this.Controls.Add(this.plusz);
            this.Controls.Add(this.points);
            this.Controls.Add(this.sorszam);
            this.Name = "FeladatUC";
            this.Size = new System.Drawing.Size(575, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label sorszam;
        private TextBox points;
        private TextBox plusz;
        private TextBox imsc;
        private CheckBox check;
        private TextBox comment;
    }
}
