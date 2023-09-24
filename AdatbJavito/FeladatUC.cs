using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdatbJavito
{
    public partial class FeladatUC : UserControl
    {
        Feladat._Feladat feladat = new Feladat._Feladat(0, 0, 0);
        bool limit = false;
        public Action? OnChanged;
        public double Points
        {
            get
            {
                double o = 0;
                return Math.Min(double.TryParse(points.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out o) ? o : 0, limit ? o : feladat.point);
            }
        }
        public double Plusz
        {
            get
            {
                double o = 0;
                return Math.Min(double.TryParse(plusz.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out o) ? o : 0, limit ? o : feladat.plusz);
            }
        }
        public double Imsc
        {
            get
            {
                double o = 0;
                return Math.Min(double.TryParse(imsc.Text, out o) ? o : 0, limit ? o : feladat.imsc);
            }
        }

        public string Comment { get => comment.Text; }
        public bool Loading = true;

        public FeladatUC()
        {
            InitializeComponent();
            InitFeladat();
        }

        void InitFeladat()
        {
            if (DesignMode || IsAncestorSiteInDesignMode || limit)
            {
                plusz.Visible = true;
                imsc.Visible = true;
                return;
            }
            plusz.Visible = feladat.plusz != 0;
            imsc.Visible = feladat.imsc != 0;
        }

        public void SetFeladat(Feladat._Feladat f, int sorszam = 0)
        {
            feladat = f;
            this.sorszam.Text = sorszam + ".feladat";
            points.Tag = f.point;
            plusz.Tag = f.plusz;
            imsc.Tag = f.imsc;
            InitFeladat();
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (check.Checked)
            {
                points.Text = feladat.point + "";
                plusz.Text = feladat.plusz + "";
                imsc.Text = feladat.imsc + "";
            }
        }
        public void Clear()
        {
            points.Clear();
            plusz.Clear();
            imsc.Clear();
            comment.Clear();
            check.Checked = false;
        }

        private void Textbox_DoubleClick(object sender, EventArgs e)
        {
            if (limit)
                return;
            if (sender is not TextBox)
                return;
            TextBox text = (TextBox)sender;
            text.Text = text.Tag.ToString();
            check.Checked = Points == feladat.point && Plusz == feladat.plusz && Imsc == feladat.imsc;
        }
        public void SetLimit(bool limit = true)
        {
            this.limit = limit;
            if (limit)
            {
                check.Checked = true;
                check_CheckedChanged(null, null);
                check.Visible = false;
                comment.Visible = false;
            }
            InitFeladat();
        }

        private void _TextChanged(object sender, EventArgs e)
        {
            if (!Loading)
                OnChanged?.Invoke();
        }
    }

}
