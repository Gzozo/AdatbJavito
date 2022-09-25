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
    public partial class FeladatUC : UserControl
    {
        Form1.Feladat feladat = new Form1.Feladat(0, 0, 0);
        public double Points
        {
            get
            {
                double o;
                return Math.Min(double.TryParse(points.Text, out o) ? o : 0, feladat.maxPoint);
            }
        }
        public double Plusz
        {
            get
            {
                double o;
                return Math.Min(double.TryParse(plusz.Text, out o) ? o : 0, feladat.plusz);
            }
        }
        public double Imsc
        {
            get
            {
                double o;
                return Math.Min(double.TryParse(imsc.Text, out o) ? o : 0, feladat.imsc);
            }
        }

        public FeladatUC()
        {
            InitializeComponent();
            InitFeladat();
        }

        void InitFeladat()
        {
            if (DesignMode)
            {
                plusz.Visible = true;
                imsc.Visible = true;
                return;
            }
            plusz.Visible = feladat.plusz != 0;
            imsc.Visible = feladat.imsc != 0;
        }

        public void SetFeladat(Form1.Feladat f, int sorszam = 0)
        {
            feladat = f;
            this.sorszam.Text = sorszam + ".feladat";
            InitFeladat();
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (check.Checked)
            {
                points.Text = feladat.maxPoint + "";
                plusz.Text = feladat.plusz + "";
                imsc.Text = feladat.imsc + "";
            }
        }
    }

}
