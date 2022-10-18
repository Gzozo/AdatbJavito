using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdatbJavito
{
    public partial class EditFeladat : Form
    {
        Feladat f;
        List<FeladatUC> ucs = new List<FeladatUC>();

        public Action<Feladat>? Result;

        public EditFeladat(Feladat f)
        {
            this.f = f;
            InitializeComponent();
            FeladatSzam.Value = f.Length;
            LoadComponents();
        }

        private void LoadComponents()
        {
            panel1.Visible = false;
            ucs.ForEach(x => panel1.Controls.Remove(x));
            ucs.Clear();
            for (int i = 0; i < f.Length; i++)
            {
                FeladatUC uc = new FeladatUC();
                uc.SetFeladat(f[i], i + 1);
                uc.Location = new Point(testfeladatuc.Location.X, testfeladatuc.Location.Y + i * 40);
                panel1.Controls.Add(uc);
                ucs.Add(uc);
                uc.SetLimit();
            }
            testfeladatuc.Visible = false;
            panel1.Visible = true;

            jegyHatar2.Points = f.jegyhatar[0];
            jegyHatar3.Points = f.jegyhatar[1];
            jegyHatar4.Points = f.jegyhatar[2];
            jegyHatar5.Points = f.jegyhatar[3];

            jegyHatarImsc.Points = f.imschatar;
        }

        private void FeladatSzam_ValueChanged(object sender, EventArgs e)
        {
            f.Resize(Convert.ToInt32(FeladatSzam.Value));
            LoadComponents();
        }

        private void EditFeladat_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < f.Length; i++)
            {
                f[i] = new Feladat._Feladat(ucs[i].Points, ucs[i].Imsc, ucs[i].Plusz);
            }

            f.jegyhatar[0] = jegyHatar2.Points;
            f.jegyhatar[1] = jegyHatar3.Points;
            f.jegyhatar[2] = jegyHatar4.Points;
            f.jegyhatar[3] = jegyHatar5.Points;

            f.imschatar = jegyHatarImsc.Points;

            f.Save();
            Result?.Invoke(f);
        }
    }
}
