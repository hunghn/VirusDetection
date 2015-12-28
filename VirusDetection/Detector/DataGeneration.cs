using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VirusDetection.Detector
{
    class DataGeneration
    {
        List<string> filenames = new List<string>();
        public TrainingData FileFragmentInput = new TrainingData();
        public TrainingData VirusFragmentInput = new TrainingData();
        public TrainingData trainingDataOutput = new TrainingData();
        public int[] state;
        private int filesRemains = 0;
        private Matching M;
        private string virusDirectory = "";
        private string benignDirectory = "";
        public string VirusDirectory { get { return virusDirectory; } set { virusDirectory = value; } }
        public string BenignDirectory { get { return benignDirectory; } set { benignDirectory = value; } }
        private string outputFile = "";
        public string OutputFile { get { return outputFile; } set { outputFile = value; } }
        private int length = 8;
        private int stepsize = 4;// 1 byte= 8 bit       
        public int Length { get { return length; } set { length = value; stepsize = value / 2; } }
        public int Stepsize { get { return stepsize; } }
        private ManualResetEvent Event;

        public DataGeneration(string _BenignDirectory, string _VirusDirectory, int d, int r, int _length, int _stepsize, bool Flag1, bool Flag2)
        {
            M = new Matching(d, r, Flag1, Flag2);
            length = _length;
            stepsize = _stepsize;
            benignDirectory = _BenignDirectory;
            virusDirectory = _VirusDirectory;

        }
        private void Readfile(string Path, bool flag)
        {
            byte[] bytes = File.ReadAllBytes(Path);
            byte[] temp = new byte[length];
            byte[] binaryArray;
            for (int i = 0; i <= bytes.Length - length; i += stepsize)
            {
                Array.Copy(bytes, i, temp, 0, length);
                binaryArray = ConvertBytesIntoBinary(temp);
                if (flag)
                {
                    if (binaryArray != null)
                        FileFragmentInput.Add(binaryArray);
                }
                else
                {
                    if (binaryArray != null)
                    {
                        VirusFragmentInput.Add(binaryArray);
                    }
                        
                }
            }
        }

        //public static void ProcessDirectory(string targetDirectory)
        //{
        //    // Process the list of files found in the directory.
        //    string[] fileEntries = Directory.GetFiles(targetDirectory);
        //    foreach (string fileName in fileEntries)
        //        ProcessFile(fileName);
        //    // Recurse into subdirectories of this directory.
        //    string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
        //    foreach (string subdirectory in subdirectoryEntries)
        //        ProcessDirectory(subdirectory);
        //}
        private void ReadDirectory(string directory, bool flag)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(directory);
            foreach (string fileName in fileEntries)
                Readfile(fileName, flag);
        }
        //private void ReadDirectory(string directory, bool flag)
        //{
        //    filenames.Clear();
        //    filenames.AddRange(Directory.GetFiles(directory, "*.exe", SearchOption.AllDirectories));
        //    filenames.AddRange(Directory.GetFiles(directory, "*.com", SearchOption.AllDirectories));
        //    filenames.AddRange(Directory.GetFiles(directory, "*.bat", SearchOption.AllDirectories));

        //    foreach (string file in filenames)
        //    {
        //        Readfile(file, flag);
        //    }
        //}
        private byte[] ConvertBytesIntoBinary(byte[] _bytes)
        {
            return _bytes.SelectMany(GetBits).ToArray();
        }
        private IEnumerable<byte> GetBits(byte b)
        {
            for (int i = 0; i < 8; i++)
            {
                if ((b & 0x80) != 0) yield return (byte)1; else yield return (byte)0;
                b *= 2;
            }
        }

        public void run()
        {
            ReadDirectory(benignDirectory, true);
            ReadDirectory(virusDirectory, false);

            // Init progressbar before work
            Utils.Utils.GLOBAL_PROGRESSBAR_COUNT_MAX = VirusFragmentInput.Count;
            Utils.Utils.GUI_SUPPORT.progressBarInit();

            NegativeSelection();
        }
        //private void NegativeSelection()
        //{
        //    filesRemains = VirusFragmentInput.Count;
        //    state = new int[VirusFragmentInput.Count];
        //    Event = new ManualResetEvent(false);
        //    for (int i = 0; i < VirusFragmentInput.Count; i++)
        //    {
        //        ThreadPool.QueueUserWorkItem(ThreadCallBack, i);
        //    }
        //    Event.WaitOne();
        //}

        private void NegativeSelection()
        {
            filesRemains = VirusFragmentInput.Count;
            state = new int[VirusFragmentInput.Count];
            Event = new ManualResetEvent(false);
            for (int i = 0; i < VirusFragmentInput.Count; i++)
            {
                ThreadCallBack(i);
            }
        }
        private void ThreadCallBack(Object ob)
        {
            int index = (int)ob;
            byte[] binaryArray = VirusFragmentInput[index];
            if (binaryArray != null && !IsMatchSelf(binaryArray))
            {
                state[index] = 0;
                try
                {
                    trainingDataOutput.Add(binaryArray);
                    Utils.Utils.GLOBAL_VIRUS_COUNT++;
                    Utils.Utils.GUI_SUPPORT.virusFragmentUpdate();
                }
                catch 
                { 
                }

            }
            else
            { 
                state[index] = 1; 
            }

            if (Interlocked.Decrement(ref filesRemains) == 0)
            {
                Event.Set();
            }

            // Update progress bar
            Utils.Utils.GUI_SUPPORT.progressBarUpdate();

        }
        private bool IsMatchSelf(byte[] _byte)
        {

            for (int j = 0; j < FileFragmentInput.Count; j++)
            {
                if (M.Match(_byte, FileFragmentInput[j]))
                    return true;
            }
            return false;
        }
        private void RemoveEquals(TrainingData TD)
        {
            for (int i = 0; i < TD.Count - 1; i++)
                for (int j = i + 1; j < TD.Count; j++)
                {
                    if (Equals(TD[i], TD[j]))
                    {
                        TD.RemoveAt(j);
                        j--;
                    }
                }
        }
        private bool Equals(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;
            for (int i = 0; i < a.Length; i++)
                if (a[i] != b[i])
                    return false;
            return true;
        }
    }
}
