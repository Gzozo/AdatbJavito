namespace AdatbJavito
{
    partial class JegyHatar
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
            point = new TextBox();
            grade = new Label();
            inclusive = new CheckBox();
            SuspendLayout();
            // 
            // point
            // 
            point.Location = new Point(47, 2);
            point.Name = "point";
            point.Size = new Size(33, 23);
            point.TabIndex = 0;
            point.TextChanged += _TextChanged;
            // 
            // grade
            // 
            grade.AutoSize = true;
            grade.Location = new Point(3, 5);
            grade.Name = "grade";
            grade.Size = new Size(16, 15);
            grade.TabIndex = 1;
            grade.Text = "1:";
            // 
            // inclusive
            // 
            inclusive.AutoSize = true;
            inclusive.Location = new Point(3, 31);
            inclusive.Name = "inclusive";
            inclusive.Size = new Size(77, 19);
            inclusive.TabIndex = 2;
            inclusive.Text = "Inclusive?";
            inclusive.UseVisualStyleBackColor = true;
            inclusive.CheckedChanged += _TextChanged;
            // 
            // JegyHatar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(inclusive);
            Controls.Add(grade);
            Controls.Add(point);
            Name = "JegyHatar";
            Size = new Size(83, 53);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox point;
        private Label grade;
        private CheckBox inclusive;
    }
}
