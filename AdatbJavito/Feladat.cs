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
        public record _Feladat(double maxPoint, double imsc, double plusz) { }

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

        public _Feladat this[int i]
        {
            get => feladatok[i];
            set => feladatok[i] = value;
        }


        public Feladat()
        {
            if (!File.Exists("feladat.json"))
            {
                //MessageBox.Show(JsonSerializer.Serialize(feladatok));
                Save();
            }
            Load();

        }
        protected Feladat(string dummy)
        {

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
            Save(this);
        }
        public void Load()
        {
            FeladatData f = Load("feladat.json");
            feladatok = f.feladatok;
            imschatar = f.imschatar;
            jegyhatar = f.jegyhatar;
        }
        void Save(Feladat f, string path = "feladat.json")
        {
            FeladatData fd = new FeladatData(f.feladatok, f.jegyhatar, f.imschatar);
            StreamWriter sw = new StreamWriter(path);
            sw.Write(JsonSerializer.Serialize(fd));
            sw.Close();
        }
        FeladatData Load(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return (FeladatData)JsonSerializer.Deserialize(sr.BaseStream, typeof(FeladatData));
            }
        }
        record FeladatData(_Feladat[] feladatok, double[] jegyhatar, double imschatar) { }
    }
}
