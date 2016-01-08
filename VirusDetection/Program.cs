using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirusDetection.Detector;

namespace VirusDetection
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _test();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        private static void _test()
        {
            //Test_ByteArrayToHex();
            
        }

        private static void _testByteToBit()
        {
            List<String> result = new List<string>();
            byte[][] array = new byte[256][];
            for(int i=0;i<256;i++)
            {
                array[i] = new byte[]{(byte)i};
                byte[] temp = Utils.Utils.Test_ConvertBytesIntoBinary(array[i]);
                String strTemp = String.Join("",temp);
                result.Add(strTemp);
            }

            int debug = 1;
        }

        private static void Test_ByteArrayToHex()
        {
            List<String> result = new List<string>();
            byte[][] array = new byte[256][];
            for(int i=0;i<256;i++)
            {
                Console.WriteLine(i);
                array[i] = new byte[]{(byte)i};
                byte[] temp = Utils.Utils.Test_ConvertBytesIntoBinary(array[i]);
                String strTemp = Utils.Utils.Test_ByteArrayToHex(temp);
                result.Add(strTemp);
            }

            int debug = 1;
        }

        

        private static void _testResize()
        {
            int[] array1 = { 1, 2, 3, 4 };
            int[] array2 = { 5, 6, 7, 8 };

            int array1OriginalLength = array1.Length;
            Array.Resize<int>(ref array1, array1OriginalLength + array2.Length);
            Array.Copy(array2, 0, array1, array1OriginalLength, 2);
            int debug = 1;
        }
    }
}
