using AForge.Neuro;
using AForge.Neuro.Learning;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VirusDetection.Clustering;

namespace VirusDetection.FileClassifier
{
    class FileClassifierManager
    {
        String _virusFolder;
        String _benignFolder;
        LKDistanceNetwork _distanceNetwork;

        internal LKDistanceNetwork DistanceNetwork
        {
            get { return _distanceNetwork; }
            set { _distanceNetwork = value; }
        }
        ActivationNetwork _activationNetwork;

        public ActivationNetwork ActivationNetwork
        {
            get { return _activationNetwork; }
            set { _activationNetwork = value; }
        }
        double[][] _input;
        double[][] _output;
        String[][] _testInput;
        int[] _formatRange;
        public FileClassifierManager(String virusFolder_, String benignFolder_, LKDistanceNetwork network_, int[] formatRange_)
        {
            _virusFolder = virusFolder_;
            _benignFolder = benignFolder_;
            _distanceNetwork = network_;

            _formatRange = formatRange_;
        }

        public FileClassifierManager(String virusFolder_, String benignFolder_, LKDistanceNetwork network_, String formatRange_)
        {
            _virusFolder = virusFolder_;
            _benignFolder = benignFolder_;
            _distanceNetwork = network_;

            _formatRange = _calcFormatRange(formatRange_); ;
        }

        private int[] _calcFormatRange(string formatRange_)
        {
            String[] strFormatRange = formatRange_.Split(new String[]{","}, StringSplitOptions.RemoveEmptyEntries);
            return strFormatRange.Select(int.Parse).ToArray();
        }

        public void train(int numOfIterator_, double errorThresold_)
        {
            // Init training set for ANN
            this.buildTrainingSet();

            return;
            // Create ANN
            _activationNetwork = new ActivationNetwork(new BipolarSigmoidFunction(), _formatRange.Length, 5, 1);
            BackPropagationLearning teacher = new BackPropagationLearning(_activationNetwork);

            // Train ANN
            double error = 0;
            bool done = false;
            int count = 0;
            while(!done)
            {
                error = teacher.RunEpoch(_input, _output);
                count++;
                done = (count >= numOfIterator_ || error <= errorThresold_);
            };
        }

        private void buildTrainingSet()
        {
            // Read virus folder and benign folder
            // extract to all 32bit string
            // compute each string => get sum of result
            String[] virusFile = Directory.GetFiles(_virusFolder, "*.*", SearchOption.AllDirectories);
            String[] benignFile = Directory.GetFiles(_benignFolder, "*.*", SearchOption.AllDirectories);

            int virusLen = virusFile.Length;
            int benignLen = benignFile.Length;
            int totalLen = virusLen + benignLen;

            _input = new double[totalLen][];
            _output = new double[totalLen][];
            _testInput = new String[totalLen][];

            int virusCount = 0;
            int benignCount = 0;
            int totalCount = 0;

            int randSize = 5;
            bool done = false;

            Random rand = new Random();

            while (!done)
            {
                // 1. For virus
                int m = Math.Min(virusLen - virusCount,rand.Next(1, randSize + 1)); // +1 because Math.Min(a,b) means min from a to b-1
                for (int i = 0; i < m; i++)
                {
                    FileClassifierData data = new FileClassifierData(_distanceNetwork, virusFile[virusCount], _formatRange);
                    Console.WriteLine("Virus: " + virusFile[virusCount]);
                    //_input[totalCount] = data.getFormatData();
                   // _input[totalCount] = data.getFormatDataTest(Utils.Utils.VIRUS_MARK);
                    _testInput[totalCount] = data.getFormatDataTest(Utils.Utils.VIRUS_MARK, virusFile[virusCount]);
                    _output[totalCount] = new double[] { Utils.Utils.VIRUS_MARK };
                    virusCount++;
                    totalCount++;
                }

                // 2. lay so lan lap random cua sach nt
                int n = Math.Min(benignLen - benignCount, rand.Next(1, randSize + 1)); // +1 because Math.Min(a,b) means min from a to b-1
                for (int j = 0; j < n; j++)
                {
                    FileClassifierData data = new FileClassifierData(_distanceNetwork, benignFile[benignCount], _formatRange);
                    Console.WriteLine(benignFile[benignCount]);
                    //_input[totalCount] = data.getFormatDataTest(Utils.Utils.BENIGN_MARK);
                    _testInput[totalCount] = data.getFormatDataTest(Utils.Utils.BENIGN_MARK, benignFile[benignCount]);
                    _output[totalCount] = new double[] { Utils.Utils.BENIGN_MARK };
                    benignCount++;
                    totalCount++;
                }

                done = (totalCount >= totalLen);
            }

            _printInput(_testInput);
           // _printInput(_output);
        }

        private void _printInput(double[][] input_)
        {
            foreach (double[] item in input_)
            {
                foreach (double _item in item)
            {
                Console.Write(_item + ",");
            }
                Console.WriteLine();
            }
        }

        private void _printInput(String[][] input_)
        {
            foreach (String[] item in input_)
            {
                foreach (String _item in item)
                {
                    Console.Write(_item + ",");
                }
                Console.WriteLine();
            }
        }

        public void saveClassifierNetwork(String fileName_)
        {
            Utils.Utils.saveNetwork(_activationNetwork, fileName_);
        }

        public void loadClassifierNetwork(String fileName_)
        {
            _activationNetwork = (ActivationNetwork)Utils.Utils.loadNetwork(fileName_);
        }
    }
}
