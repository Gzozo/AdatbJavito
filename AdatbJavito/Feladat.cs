using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AdatbJavito
{
    public class Feladat
    {
        public record _Feladat(double point, double imsc, double plusz) { }

        public _Feladat[] feladatok = new _Feladat[]
        {
            new _Feladat(0.5,0,0),
            new _Feladat(1,0,0.5),
            new _Feladat(1,0,0),
            new _Feladat(1,1,0),
            new _Feladat(1.5,0,1),
            new _Feladat(0.5,0,0),
        };

        public double[] jegyhatar = new double[4]
        {
            5.01,7,8,9
        };
        public double imschatar = 10;

        public int Length => feladatok.Length;
        public double Max => feladatok.Sum(x => x.point + x.imsc + x.plusz);

        public string Name;
        private string path;

        public _Feladat this[int i]
        {
            get => feladatok[i];
            set => feladatok[i] = value;
        }


        public Feladat(string path = "Data/feladat.json", string name = "Custom")
        {
            Name = name;
            this.path = path;
            if (!File.Exists(path))
            {
                //MessageBox.Show(JsonSerializer.Serialize(feladatok));
                Save();
            }
            Load(path);

        }
        public void Resize(int length)
        {
            int before = Length;
            Array.Resize(ref feladatok, length);
            if (before < length)
            {
                for (int i = before; i < length; i++)
                {
                    feladatok[i] = new _Feladat(0, 0, 0);
                }
            }
        }
        public void Save()
        {
            Save(this, path);
        }
        public void Load(string path)
        {
            FeladatData f = LoadData(path);
            feladatok = f.feladatok;
            imschatar = f.imschatar;
            jegyhatar = f.jegyhatar;
            Name = f.name;
        }
        private void Save(Feladat f, string path)
        {
            FeladatData fd = new FeladatData(f.feladatok, f.jegyhatar, f.imschatar, f.Name);
            StreamWriter sw = new StreamWriter(path);
            sw.Write(JsonSerializer.Serialize(fd));
            sw.Close();
        }
        FeladatData LoadData(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                try
                {
                    return JsonSerializer.Deserialize(sr.BaseStream, typeof(FeladatData)) as FeladatData;
                }
                catch
                {
                    return new FeladatData(feladatok, jegyhatar, imschatar, Name);
                }
            }
        }
        record FeladatData(_Feladat[] feladatok, double[] jegyhatar, double imschatar, string name) { }
    }
}
