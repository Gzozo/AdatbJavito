namespace AdatbJavito
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neptun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Panel();
            this.testfeladatuc = new AdatbJavito.FeladatUC();
            this.button1 = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.points.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePatternToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changePatternToolStripMenuItem
            // 
            this.changePatternToolStripMenuItem.Name = "changePatternToolStripMenuItem";
            this.changePatternToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.changePatternToolStripMenuItem.Text = "Change Pattern";
            this.changePatternToolStripMenuItem.Click += new System.EventHandler(this.changePatternToolStripMenuItem_Click);
            // 
            // neptun
            // 
            this.neptun.Location = new System.Drawing.Point(92, 53);
            this.neptun.Name = "neptun";
            this.neptun.Size = new System.Drawing.Size(100, 23);
            this.neptun.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Neptun:";
            // 
            // points
            // 
            this.points.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.points.AutoScroll = true;
            this.points.Controls.Add(this.testfeladatuc);
            this.points.Location = new System.Drawing.Point(36, 108);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(592, 241);
            this.points.TabIndex = 3;
            // 
            // testfeladatuc
            // 
            this.testfeladatuc.Location = new System.Drawing.Point(16, 12);
            this.testfeladatuc.Name = "testfeladatuc";
            this.testfeladatuc.Size = new System.Drawing.Size(573, 33);
            this.testfeladatuc.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(495, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearBtn.Location = new System.Drawing.Point(414, 384);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.points);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.neptun);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Adatb Javító v0.2 internal build not for public use paid version";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.points.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem changePatternToolStripMenuItem;
        private TextBox neptun;
        private Label label1;
        private Panel points;
        private Button button1;
        private FeladatUC testfeladatuc;
        private Button clearBtn;
    }
}