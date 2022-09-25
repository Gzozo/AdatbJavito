namespace AdatbJavito
{
    public partial class Form1 : Form
    {
        public record Feladat(double maxPoint, double imsc, double plusz) { }
        public record FeladatUI(Label Label, TextBox Max, TextBox Imsc, TextBox Plusz, CheckBox Checkbox) { }

        Feladat[] feladatok = new Feladat[]
        {
            new Feladat(0.5,0,0),
            new Feladat(1,0,0.5),
            new Feladat(1,0,0),
            new Feladat(1,1,0),
            new Feladat(1.5,0,1),
            new Feladat(0.5,0,0),
        };

        double[] jegyhatar = new double[4]
        {
            3.01,4,5,6
        };
        double imschatar = 5.5;
        string[] jegyek = "elégtelen elégséges közepes jó jeles".Split(' ');

        // List<FeladatUI> uis = new List<FeladatUI>();
        List<FeladatUC> ucs = new List<FeladatUC>();
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < feladatok.Length; i++)
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
                uc.SetFeladat(feladatok[i], i + 1);
                uc.Location = new Point(testfeladatuc.Location.X, testfeladatuc.Location.Y + i * 30);
                points.Controls.Add(uc);
                ucs.Add(uc);

            }
            /*testTextbox.Visible = false;
            testTextbox2.Visible = false;
            testTextbox3.Visible = false;
            testCheckbox.Visible = false;
            testLabel.Visible = false;*/
            testfeladatuc.Visible = false;
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

            string[] pontok = new string[6];
            double sum = 0, imsc = 0;
            int jegy = 1;

            for (int i = 0; i < feladatok.Length; i++)
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
                if (feladatok[i].plusz != 0)
                    pontok[i] += $" + {plusz}p";
                if (feladatok[i].imsc != 0)
                    pontok[i] += $" + (i){im}p";
            }
            while (jegy < 5 && jegyhatar[jegy - 1] <= sum)
                jegy++;
            if (sum < imschatar)
                imsc = 0;
            else
            {
                imsc = Math.Min((sum - 5.5) / 6.5 * 100, 5);
            }

            string minta =
@$"Neptun:{neptun.Text}
1. {pontok[0]} / 0,5p
2. {pontok[1]} / 1p és 0,5 plusz pont
3. {pontok[2]} / 1p
4. {pontok[3]} / 1 + (i)1p
5. {pontok[4]} / 1,5p és 1 plusz pont
6. {pontok[5]} / 0,5p

Összesen: {sum}p, egy tizedes jegyre kerekítve
iMSc pont: {imsc}p
Az iMSc pontokra jogosultság határa: 5,5p az(i) (rész)feladatokon elért pontszám nélkül.
A labordokumentációra {jegyek[jegy - 1]}({jegy}) jegyet adok.
--
2: 3 <; 3: 4 <=; 4: 5 <=; 5: 6 <= ";
            MessageBox.Show(minta);
            Clipboard.SetText(minta);
        }

        private void changePatternToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Invalidate();
        }

    }
}