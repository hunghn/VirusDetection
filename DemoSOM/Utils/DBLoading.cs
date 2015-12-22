using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSOM.Utils
{

    class DBLoading
    {
        public double[][] loadDB(String fileName_)
        {
            double[][] _input;
            var lines = File.ReadAllLines(fileName_);
            var len = lines.Length;
            _input = new double[len][];
            int countX = 0;
            foreach (var line in lines)
            {
                String[] raw = line.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                int countY = 0;
                _input[countX] = new double[raw.Length];
                foreach (var item in raw)
                {
                    _input[countX][countY] = double.Parse(item);
                    countY++;
                }
                countX++;

            }
            return _input;
        }
    }
}
