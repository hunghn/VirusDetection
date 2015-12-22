using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSOM
{
    class DBGenerate
    {
        private int _divisorNum;
        Point[] _input;

        public DBGenerate(int divisorNum_=4)
        {
            _input = null;
            _divisorNum = divisorNum_;
        }

        public void generateData(int numOfVector_)
        {
            _input = new Point[numOfVector_];

            HashSet<int> hm = new HashSet<int>();
            int count = 0;
            while(count<numOfVector_)
            {
                int key = new Random().Next(0, 100);
                if (hm.Contains(key))
                    continue;
                hm.Add(key);
                // key % 4 = 0 => value = 1 => Vr
                int value = (key % _divisorNum==0?1:0);
                _input[count] = new Point(key, value);
                count++;
            }
        }

        public void writeLearnDB(String fileName_)
        {
            StreamWriter file = new StreamWriter(fileName_);
            int len = _input.Length;
            for (int i = 0; i < len - 1; i++)
            {
                file.WriteLine(_input[i].X + "," + _input[i].Y);
            }
            file.Write(_input[len - 1].X + "," + _input[len - 1].Y);
            file.Close();

        }

        public void writeTestDB(String fileName_)
        {
            StreamWriter file = new StreamWriter(fileName_);
            int len = _input.Length;
            for (int i = 0; i < len - 1; i++)
            {
                file.WriteLine(_input[i].X);
            }
            file.Write(_input[len - 1].X );
            file.Close();
        }

    }
}
