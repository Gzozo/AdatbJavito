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
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            changePatternToolStripMenuItem = new ToolStripMenuItem();
            neptun = new TextBox();
            label1 = new Label();
            points = new Panel();
            testfeladatuc = new FeladatUC();
            button1 = new Button();
            clearBtn = new Button();
            menuStrip1.SuspendLayout();
            points.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(799, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changePatternToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // changePatternToolStripMenuItem
            // 
            changePatternToolStripMenuItem.Name = "changePatternToolStripMenuItem";
            changePatternToolStripMenuItem.Size = new Size(156, 22);
            changePatternToolStripMenuItem.Text = "Change Pattern";
            changePatternToolStripMenuItem.Click += changePatternToolStripMenuItem_Click;
            // 
            // neptun
            // 
            neptun.Location = new Point(92, 53);
            neptun.Name = "neptun";
            neptun.Size = new Size(100, 23);
            neptun.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 56);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Neptun:";
            // 
            // points
            // 
            points.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            points.AutoScroll = true;
            points.Controls.Add(testfeladatuc);
            points.Location = new Point(36, 108);
            points.Name = "points";
            points.Size = new Size(592, 254);
            points.TabIndex = 3;
            // 
            // testfeladatuc
            // 
            testfeladatuc.Location = new Point(16, 12);
            testfeladatuc.Name = "testfeladatuc";
            testfeladatuc.Size = new Size(573, 33);
            testfeladatuc.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(495, 397);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Export";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clearBtn.Location = new Point(414, 397);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 5;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 463);
            Controls.Add(clearBtn);
            Controls.Add(button1);
            Controls.Add(points);
            Controls.Add(label1);
            Controls.Add(neptun);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Adatb Javító v0.3 internal build not for public use paid version";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            points.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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