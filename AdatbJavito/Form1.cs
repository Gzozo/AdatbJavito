using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace AdatbJavito
{
    public partial class Form1 : Form
    {
        public record FeladatUI(Label Label, TextBox Max, TextBox Imsc, TextBox Plusz, CheckBox Checkbox) { }

        #region Feladat stats

        Feladat feladat = new Feladat();

        #endregion

        string[] jegyek = "elégtelen elégséges közepes jó jeles".Split(' ');

        // List<FeladatUI> uis = new List<FeladatUI>();
        List<FeladatUC> ucs = new List<FeladatUC>();
        public Form1()
        {
            InitializeComponent();

            if (!File.Exists("minta.txt"))
                CreateMinta();


            /*if (!File.Exists("feladat.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Feladat[]));
                using (FileStream fs = new FileStream("feladat.xml", FileMode.Create))
                {
                    JsonSerializer.Serialize(feladatok);
                    serializer.Serialize(fs, feladatok);
                }
            }*/

            GenerateUCs();
            /*testTextbox.Visible = false;
            testTextbox2.Visible = false;
            testTextbox3.Visible = false;
            testCheckbox.Visible = false;
            testLabel.Visible = false;*/
            testfeladatuc.Visible = false;
        }

        private void GenerateUCs()
        {
            ucs.ForEach(x => points.Controls.Remove(x));
            ucs.Clear();
            for (int i = 0; i < feladat.Length; i++)
            {
                /*CheckBox checkBox = new CheckBox();
                TextBox textBox = new TextBox();
                TextBox textBox2 = new TextBox();
                TextBox textBox3 = new TextBox();
                Label label = new Label();

                label.Text = (i + 1).ToString() + " feladat";
                //textBox.Text = "Hello there " + i;
                textBox.Size = testTextbox.Size;
                textBox2.Size = testTextbox2.Size;
                textBox3.Size = testTextbox3.Size;
                checkBox.Tag = i;

                label.Location = new Point(testLabel.Location.X, testLabel.Location.Y + i * 30);
                textBox.Location = new Point(testTextbox.Location.X, testTextbox.Location.Y + i * 30);
                textBox2.Location = new Point(testTextbox2.Location.X, testTextbox2.Location.Y + i * 30);
                textBox3.Location = new Point(testTextbox3.Location.X, testTextbox3.Location.Y + i * 30);
                checkBox.Location = new Point(testCheckbox.Location.X, testCheckbox.Location.Y + i * 30);


                points.Controls.Add(checkBox);
                if (feladatok[i].maxPoint != 0)
                    points.Controls.Add(textBox);
                if (feladatok[i].imsc != 0)
                    points.Controls.Add(textBox2);
                if (feladatok[i].plusz != 0)
                    points.Controls.Add(textBox3);
                points.Controls.Add(label);

                checkBox.CheckedChanged += CheckBox_CheckedChanged;

                uis.Add(new FeladatUI(label, textBox, textBox2, textBox3, checkBox));*/

                FeladatUC uc = new FeladatUC();
                uc.SetFeladat(feladat[i], i + 1);
                uc.Location = new Point(testfeladatuc.Location.X, testfeladatuc.Location.Y + i * 40);
                points.Controls.Add(uc);
                ucs.Add(uc);

            }
        }

        private void CheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender == null || sender is not CheckBox)
                return;
            CheckBox check = (CheckBox)sender;
            if (check.Checked)
            {
                /*uis[(int)check.Tag].Max.Text = feladatok[(int)check.Tag].maxPoint.ToString();
                uis[(int)check.Tag].Imsc.Text = feladatok[(int)check.Tag].imsc.ToString();
                uis[(int)check.Tag].Plusz.Text = feladatok[(int)check.Tag].plusz.ToString();*/
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * Neptun:
                1. /0,5p
                2. /1p és 0,5 plusz pont
                3. /1p
                4. /1+(i)1p
                5. /1,5p és 1 plusz pont
                6. /0,5p

                Összesen: p, egy tizedes jegyre kerekítve
                iMSc pont: p
                Az iMSc pontokra jogosultság határa: 5,5p az (i) (rész)feladatokon elért pontszám nélkül.
                A labordokumentációra () jegyet adok.
                --
                2: 3<; 3: 4<=; 4: 5<=; 5: 6<=
              */

            string[] pontok = new string[feladat.Length];
            double sum = 0, imsc = 0;
            int jegy = 1;

            for (int i = 0; i < feladat.Length; i++)
            {
                double max, im, plusz;
                /*max = Math.Min(double.TryParse(uis[i].Max.Text, out max) ? max : 0, feladatok[i].maxPoint);
                im = Math.Min(double.TryParse(uis[i].Imsc.Text, out im) ? im : 0, feladatok[i].imsc);
                plusz = Math.Min(double.TryParse(uis[i].Plusz.Text, out plusz) ? plusz : 0, feladatok[i].plusz);*/
                max = ucs[i].Points;
                im = ucs[i].Imsc;
                plusz = ucs[i].Plusz;

                sum += max + plusz + im;
                imsc += im;

                pontok[i] = $"{max}p";
                if (feladat[i].plusz != 0)
                    pontok[i] += $" + {plusz}p";
                if (feladat[i].imsc != 0)
                    pontok[i] += $" + (i){im}p";
            }
            while (jegy < 5 && feladat.jegyhatar[jegy - 1] <= sum)
                jegy++;
            if (sum - imsc < feladat.imschatar)
                imsc = 0;
            else if (imsc > 0)
            {
                imsc = Math.Min((sum - 5.5) / 6.5 * 100, 5);
            }

            if (!File.Exists("minta.txt"))
            {
                CreateMinta();
            }

            /* string minta =
 @$"Neptun:{neptun.Text}

 1. {pontok[0]} / 0,5p  {ucs[0].Comment}
 2. {pontok[1]} / 1p és 0,5 plusz pont   {ucs[1].Comment}
 3. {pontok[2]} / 1p   {ucs[2].Comment}
 4. {pontok[3]} / 1 + (i)1p   {ucs[3].Comment}
 5. {pontok[4]} / 1,5p és 1 plusz pont   {ucs[4].Comment}
 6. {pontok[5]} / 0,5p   {ucs[5].Comment}

 Összesen: {sum}p
 iMSc pont: {imsc}p
 Az iMSc pontokra jogosultság határa: 5,5p az(i) (rész)feladatokon elért pontszám nélkül.
 A labordokumentációra {jegyek[jegy - 1]}({jegy}) jegyet adok.
 --
 2: 3 <; 3: 4 <=; 4: 5 <=; 5: 6 <= ";*/
            StreamReader sr = new StreamReader("minta.txt");
            string minta = sr.ReadToEnd();

            Dictionary<string, MatchEvaluator> mask = new Dictionary<string, MatchEvaluator>()
            {
                {"\\[neptun\\]", (match) => neptun.Text },
                {"\\[points\\]", (match) => Points(pontok) },
                {"\\[sum\\]", (match) => sum.ToString() },
                {"\\[imsc\\]", (match) => imsc.ToString() },
                {"\\[min_imsc\\]", (match) => feladat.imschatar.ToString() },
                {"\\[grade\\]", (match) => jegyek[jegy-1] + $"({jegy})" },
                {"\\[grade_point\\]", (match) => GradePoints() },
                {"\\r?\\n?\\[good_job(?: (.+))?\\]", (match) =>
                    sum == feladat.Max?
                    ("\n"+(match.Groups.Count > 1 &&  match.Groups[1].Value != "" ? match.Groups[1].Value : "Szép munka"))
                     :"" },
            };

            foreach (var item in mask)
            {
                //minta = minta.Replace(item.Key, item.Value());
                minta = Regex.Replace(minta, item.Key, item.Value);
            }


            MessageBox.Show(minta);
            Clipboard.SetText(minta);
        }

        private string Points(string[] pontok)
        {
            //1. {pontok[0]} / 0,5p  {ucs[0].Comment}
            StringBuilder ret = new StringBuilder();

            for (int i = 0; i < pontok.Length; i++)
            {
                ret.Append(i + 1).Append(". ").Append(pontok[i]).Append(" / ").Append(feladat[i].point).Append("p ");
                if (feladat[i].plusz > 0)
                    ret.Append("+ ").Append(feladat[i].plusz).Append("p ");
                if (feladat[i].imsc > 0)
                    ret.Append("+ (i)").Append(feladat[i].imsc).Append("p ");

                ret.Append(ucs[i].Comment).AppendLine();
            }

            return ret.ToString();
        }

        private string GradePoints()
        {
            /*
            double[] jegyhatar = new double[4]
            {
            3.01,4,5,6
            };*/
            //2: 3 <; 3: 4 <=; 4: 5 <=; 5: 6 <=
            StringBuilder ret = new StringBuilder();

            for (int i = 0; i < feladat.jegyhatar.Length; i++)
            {
                ret.Append(i + 2).Append(": ");
                double hatar = Math.Round(feladat.jegyhatar[i], 1);
                ret.Append(hatar).Append(" <").Append(hatar < feladat.jegyhatar[i] ? "" : "=").Append("; ");
            }

            return ret.ToString();


        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to clear all input fields?", "Clear", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ucs.ForEach(x => x.Clear());
                neptun.Clear();
            }
        }

        private void changePatternToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditFeladat ef = new EditFeladat(feladat);
            ef.Show();
            ef.Result += Ef_FormClosed;
        }

        private void Ef_FormClosed(Feladat f)
        {
            feladat = f;
            GenerateUCs();
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void CreateMinta()
        {
            StreamWriter sw = new StreamWriter("minta.txt");
            sw.Write("Neptun: [neptun]\r\n\r\n[points]\r\n\r\nÖsszesen: [sum]p\r\niMSc pont: [imsc]p\r\nAz iMSc pontokra jogosultság határa: [min_imsc]p az(i) (rész)feladatokon elért pontszám nélkül.\r\nA labordokumentációra [grade] jegyet adok.\r\n[good_job]\r\n--\r\n[grade_point]");
            sw.Close();
        }

    }
}