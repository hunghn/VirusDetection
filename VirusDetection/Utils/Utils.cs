using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VirusDetection.Clustering;
using VirusDetection.Detector;

namespace VirusDetection.Utils
{
    class Utils
    {
        public static int VIRUS_MARK = 1; // define virus as 1 and
        public static int BENIGN_MARK = 0;// benign as 0

        #region Detector Utils
        public static double[][] correctAndMixDetector(TrainingData VirusFragments, TrainingData BenignFragments)
        {
            return correctAndMixDetector(VirusFragments, VirusFragments.Count, BenignFragments, BenignFragments.Count);
        }
        public static double[][] correctAndMixDetector(TrainingData VirusFragments, int virusLen_, TrainingData BenignFragments, int benignLen_)
        {

            int virusLen = Math.Min(VirusFragments.Count, virusLen_);
            int benignLen = Math.Min(BenignFragments.Count, benignLen_);
            int totalLen = virusLen + benignLen;

            double[][] mixData = new double[virusLen + benignLen][];

            int virusCount = 0;
            int benignCount = 0;
            int totalCount = 0;

            int randSize = benignLen / virusLen;
            bool done = false;

            Random rand = new Random();

            while (!done)
            {
                // 1. kiem tra vr con khong, lay so lan lap random cua vr trong gioi han con lai hoac la size
                int n = Math.Min(1, virusLen - virusCount);
                for (int i = 0; i < n; i++)
                {
                    mixData[totalCount] = new double[5];

                    byte[] byteArray = VirusFragments[virusCount];
                    String hexStr = ByteArrayToHex(byteArray);
                    String[] hex4 = Split(hexStr, 2);
                    HexArray2DecArray(hex4, ref mixData[totalCount]);
                    mixData[totalCount][4] = VIRUS_MARK;

                    virusCount++;
                    totalCount++;
                }

                // 2. lay so lan lap random cua sach nt
                //if(benignLen - benignCount > 0)
                {
                    int m = rand.Next(0, Math.Min(randSize, benignLen - benignCount + 1));

                    Console.WriteLine(m);
                    for (int i = 0; i < m; i++)
                    {
                        mixData[totalCount] = new double[5];

                        byte[] byteArray = BenignFragments[benignCount];
                        String hexStr = ByteArrayToHex(byteArray);
                        String[] hex4 = Split(hexStr, 2);
                        HexArray2DecArray(hex4, ref mixData[totalCount]);
                        mixData[totalCount][4] = BENIGN_MARK;

                        benignCount++;
                        totalCount++;
                    }
                }
                
                // for vr
                // for sach
                done = (totalCount >= totalLen);
            }

            return mixData;
        }


        public static void saveMixDetector(double[][] input_, String fileName_)
        {
            StreamWriter file = new StreamWriter(fileName_);
            int len0 = input_.Length;
            int len1 = input_[0].Length;

            for (int i = 0; i < len0 - 1; i++)
            {
                for (int j = 0; j < len1 - 1; j++)
                {
                    file.Write(input_[i][j] + ",");
                }
                file.WriteLine(input_[i][len1 - 1]);
            }

            // Write the last one
            for (int j = 0; j < len1 - 1; j++)
            {
                file.Write(input_[len0 - 1][j] + ",");
            }
            file.Write(input_[len0 - 1][len1 - 1]);

            // Close file
            file.Close();
        }

        public static double[][] loadMixDetector(String fileName_)
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

        public static String[] Split(string str, int chunkSize)
        {
            int len = str.Length;
            int elementCount = len / chunkSize;
            String[] result = new String[elementCount];
            for (int i = 0, j = 0; i < elementCount; i++, j += chunkSize)
            {
                result[i] = str.Substring(j, chunkSize);
            }
            return result;
        }

        private static String ByteArrayToHex(byte[] byteArray)
        {
            StringBuilder temp = new StringBuilder();
            foreach (byte x in byteArray)
            {
                temp.Append(x);
            }
            String strBinary = temp.ToString();
            String strHex = Convert.ToInt32(strBinary, 2).ToString("X8");
            return strHex;
        }

        private static void HexArray2DecArray(String[] hexArray_, ref double[] decArray_)
        {
            int len = hexArray_.Length;
            for (int i = 0; i < len; i++)
            {
                decArray_[i] = Convert.ToInt32(hexArray_[i], 16);
            }
        }


        #endregion

        #region Clustering Utils
        public static void saveLKDistanceNetwork(LKDistanceNetwork network_, String fileName_)
        {
            network_.Save(fileName_);
        }


        #endregion

        #region File Classifier Utils

        #endregion

        #region xxx Utils

        #endregion
        
        public static bool checkVirus(double property)
        {
            if (property == VIRUS_MARK)
                return true;
            else if (property == BENIGN_MARK)
                return false;

            throw new Exception();
        }

        
        
        #region Unused Method

        private static int[] HexArray2DecArray(String[] hexArray_)
        {
            int len = hexArray_.Length;
            int[] result = new int[len];
            for (int i = 0; i < len; i++)
            {
                result[i] = Convert.ToInt32(hexArray_[i], 16);
            }
            return result;
        }

        #endregion

        public static LKDistanceNetwork loadLKDistanceNetwork(string fileName_)
        {
            return (LKDistanceNetwork)LKDistanceNetwork.Load(fileName_);
        }
    }
}
