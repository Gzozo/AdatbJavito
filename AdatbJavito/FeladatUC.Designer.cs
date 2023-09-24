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
            sorszam = new Label();
            points = new TextBox();
            plusz = new TextBox();
            imsc = new TextBox();
            check = new CheckBox();
            comment = new TextBox();
            SuspendLayout();
            // 
            // sorszam
            // 
            sorszam.AutoSize = true;
            sorszam.Location = new Point(5, 6);
            sorszam.Name = "sorszam";
            sorszam.Size = new Size(53, 15);
            sorszam.TabIndex = 0;
            sorszam.Text = "X.feladat";
            // 
            // points
            // 
            points.Location = new Point(64, 3);
            points.Name = "points";
            points.PlaceholderText = "0";
            points.Size = new Size(48, 23);
            points.TabIndex = 1;
            points.Tag = "";
            points.TextChanged += _TextChanged;
            points.DoubleClick += Textbox_DoubleClick;
            // 
            // plusz
            // 
            plusz.Location = new Point(118, 3);
            plusz.Name = "plusz";
            plusz.PlaceholderText = "0";
            plusz.Size = new Size(48, 23);
            plusz.TabIndex = 1;
            plusz.Tag = "";
            plusz.TextChanged += _TextChanged;
            plusz.DoubleClick += Textbox_DoubleClick;
            // 
            // imsc
            // 
            imsc.Location = new Point(172, 3);
            imsc.Name = "imsc";
            imsc.PlaceholderText = "0";
            imsc.Size = new Size(48, 23);
            imsc.TabIndex = 1;
            imsc.Tag = "";
            imsc.TextChanged += _TextChanged;
            imsc.DoubleClick += Textbox_DoubleClick;
            // 
            // check
            // 
            check.AutoSize = true;
            check.Location = new Point(226, 7);
            check.Name = "check";
            check.Size = new Size(15, 14);
            check.TabIndex = 2;
            check.UseVisualStyleBackColor = true;
            check.CheckedChanged += check_CheckedChanged;
            // 
            // comment
            // 
            comment.Location = new Point(247, 3);
            comment.Name = "comment";
            comment.Size = new Size(310, 23);
            comment.TabIndex = 3;
            // 
            // FeladatUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comment);
            Controls.Add(check);
            Controls.Add(imsc);
            Controls.Add(plusz);
            Controls.Add(points);
            Controls.Add(sorszam);
            Name = "FeladatUC";
            Size = new Size(575, 30);
            ResumeLayout(false);
            PerformLayout();
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
