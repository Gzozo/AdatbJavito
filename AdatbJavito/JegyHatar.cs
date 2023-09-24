using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdatbJavito
{
    public partial class JegyHatar : UserControl
    {
        [Category("MyCategory")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Grade
        {
            set => grade.Text = value + ":";
            get => grade.Text.Substring(0, grade.Text.Length - 1);
        }
        [Category("MyCategory")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public double Points
        {
            get => double.Parse(point.Text) + (inclusive.Checked ? 0.0 : 0.01);
            set
            {
                double point = Math.Round(value, 1);
                inclusive.Checked = point >= value;
                this.point.Text = point.ToString();
            }
        }


        [Category("MyCategory")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public event Action? OnChanged;
        public JegyHatar()
        {
            InitializeComponent();
            Points = 0;
        }

        private void _TextChanged(object sender, EventArgs e)
        {
            OnChanged?.Invoke();
        }
    }
}
