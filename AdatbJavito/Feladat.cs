﻿using System;
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
            3.01,4,5,6
        };
        public double imschatar = 5.5;

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
        public void Save()
        {
            StreamWriter sw = new StreamWriter("feladat.json");
            sw.Write(JsonSerializer.Serialize(feladatok));
            sw.Close();
        }
        public void Load()
        {
            feladatok = (_Feladat[])JsonSerializer.Deserialize(File.OpenRead("feladat.json"), typeof(_Feladat[]));
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
    }
}