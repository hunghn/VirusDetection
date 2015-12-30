using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //_test();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        private static void _test()
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
