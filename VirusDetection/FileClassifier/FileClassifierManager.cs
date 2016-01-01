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

        private int _numOfHiddenNeuron;
        private int _numOfOutputNeuron;
        private int _numOfIterator;
        private double _errorThresold;

        String _virusFolder;
        String _benignFolder;
        LKDistanceNetwork _distanceNetwork;

        double[][] _input;
        double[][] _output;
        String[][] _testInput;
        int[] _formatRange;        

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
       

        public FileClassifierManager(int numOfHiddenNeuron_, int numOfOutputNeuron_,  int numOfIterator_, double errorThresold_, String virusFolder_, String benignFolder_, LKDistanceNetwork network_, String formatRange_)
        {
            // TODO: Complete member initialization
            _numOfHiddenNeuron = numOfHiddenNeuron_;
            _numOfOutputNeuron = numOfOutputNeuron_;
            _numOfIterator = numOfIterator_;
            _errorThresold = errorThresold_;

            _virusFolder = virusFolder_;
            _benignFolder = benignFolder_;
            _distanceNetwork = network_;

            _formatRange = Utils.Utils.calcFormatRange(formatRange_);

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
                int m = Math.Min(virusLen - virusCount, rand.Next(1, randSize + 1)); // +1 because Math.Min(a,b) means min from a to b-1
                for (int i = 0; i < m; i++)
                {
                    FileClassifierData data = new FileClassifierData(_distanceNetwork, virusFile[virusCount], _formatRange);
                    Console.WriteLine("Virus: " + virusFile[virusCount]);
                    _input[totalCount] = data.getFormatData();

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
                    _input[totalCount] = data.getFormatData();
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

        public void trainActiveNetwork()
        {
            // Init training set for ANN
            this.buildTrainingSet();

            // Create ANN
            _activationNetwork = new ActivationNetwork(new BipolarSigmoidFunction(), _formatRange.Length, _numOfHiddenNeuron, _numOfOutputNeuron);
            BackPropagationLearning teacher = new BackPropagationLearning(_activationNetwork);

            // Train ANN
            double error = 0;
            bool done = false;
            int count = 0;
            while(!done)
            {
                error = teacher.RunEpoch(_input, _output);
                count++;
                done = (count >= _numOfIterator || error <= _errorThresold);
            };
        }

        public void saveActiveNetwork(String fileName_)
        {
            Utils.Utils.saveNetwork(_activationNetwork, fileName_);
        }

        public void loadActiveNetwork(String fileName_)
        {
            _activationNetwork = (ActivationNetwork)Utils.Utils.loadNetwork(fileName_);
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

    }
}
