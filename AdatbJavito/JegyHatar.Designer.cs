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
            this.point = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.Label();
            this.inclusive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(47, 2);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(33, 23);
            this.point.TabIndex = 0;
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Location = new System.Drawing.Point(3, 5);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(16, 15);
            this.grade.TabIndex = 1;
            this.grade.Text = "1:";
            // 
            // inclusive
            // 
            this.inclusive.AutoSize = true;
            this.inclusive.Location = new System.Drawing.Point(3, 31);
            this.inclusive.Name = "inclusive";
            this.inclusive.Size = new System.Drawing.Size(77, 19);
            this.inclusive.TabIndex = 2;
            this.inclusive.Text = "Inclusive?";
            this.inclusive.UseVisualStyleBackColor = true;
            // 
            // JegyHatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.inclusive);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.point);
            this.Name = "JegyHatar";
            this.Size = new System.Drawing.Size(83, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox point;
        private Label grade;
        private CheckBox inclusive;
    }
}
