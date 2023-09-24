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
        Dictionary<string, string> samples = new Dictionary<string, string>()
        {
            //Add a new sample entry
            {"Oracle","Data/oracle.json"},
            {"SQL1","Data/sql1.json"},
            {"SQL2","Data/sql2.json"},
            {"SQL3","Data/sql3.json"},
            {"Opti","Data/opti.json"},
            {"Custom", "Data/feladat.json" }
        };

        public Action<Feladat>? Result;

        public EditFeladat(Feladat f)
        {
            this.f = f;
            InitializeComponent();

            samplesComboBox.Items.AddRange(samples.Keys.ToArray());
            samplesComboBox.Text = f.Name;

            LoadFeladatComponents();

            jegyHatar2.OnChanged += ChangedValue;
            jegyHatar3.OnChanged += ChangedValue;
            jegyHatar4.OnChanged += ChangedValue;
            jegyHatar5.OnChanged += ChangedValue;
            jegyHatarImsc.OnChanged += ChangedValue;

            FeladatSzam.ValueChanged += FeladatSzam_ValueChanged;


        }
        private bool loading = false;

        private void LoadFeladatComponents()
        {
            loading = true;
            panel1.Visible = false;
            ucs.ForEach(x => panel1.Controls.Remove(x));
            ucs.Clear();
            for (int i = 0; i < f.Length; i++)
            {
                FeladatUC uc = new FeladatUC();
                uc.OnChanged += ChangedValue;
                uc.SetFeladat(f[i], i + 1);
                uc.Location = new Point(testfeladatuc.Location.X, testfeladatuc.Location.Y + i * 40);
                panel1.Controls.Add(uc);
                ucs.Add(uc);
                uc.SetLimit();
                uc.Loading = false;
            }
            testfeladatuc.Visible = false;
            panel1.Visible = true;

            jegyHatar2.Points = f.jegyhatar[0];
            jegyHatar3.Points = f.jegyhatar[1];
            jegyHatar4.Points = f.jegyhatar[2];
            jegyHatar5.Points = f.jegyhatar[3];

            jegyHatarImsc.Points = f.imschatar;
            FeladatSzam.Value = f.Length;
            loading = false;
        }

        private void FeladatSzam_ValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            SaveChangesToFeladat();
            f.Resize(Convert.ToInt32(FeladatSzam.Value));
            LoadFeladatComponents();
            ChangedValue();
        }

        private void EditFeladat_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveChangesToFeladat();

            f.Save();
            Result?.Invoke(f);
        }

        private void SaveChangesToFeladat()
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

            f.Name = samplesComboBox.SelectedItem.ToString()!;
        }

        private void samplesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = samplesComboBox.SelectedItem.ToString()!;
            if (selectedItem != "Custom" && samples.ContainsKey(selectedItem))
            {
                f.Load(samples[selectedItem]);
                LoadFeladatComponents();
            }
        }
        private void ChangedValue()
        {
            if (!loading && samplesComboBox.SelectedItem.ToString() != "Custom")
            {
                samplesComboBox.SelectedItem = "Custom";
            }
        }
    }
}
