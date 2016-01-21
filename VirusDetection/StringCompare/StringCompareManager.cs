using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VirusDetection.Detector;

namespace VirusDetection.StringCompare
{
    
    class StringCompareManager
    {
        private TrainingData _detector;
        public double[][] _graphMap;
        private StringCompareData _stringCompareData;

        String _virusFolder;
        String _benignFolder;

        bool _done;

        internal StringCompareData StringCompareData
        {
            get { return _stringCompareData; }
            set { _stringCompareData = value; }
        }

        public StringCompareManager()
        {
            _detector = new TrainingData();
            _initialize();
        }

        private void _initialize()
        {
            _graphMap = new double[0][];

            _done = false;
        }

        public StringCompareManager(TrainingData detector_, int hamingThresold_, int rContinuousThresold_, int length_, int stepsize_, Boolean useHaming_, Boolean useRContinuous_, String virusFolder_, String benignFolder_)
        {
            _detector = detector_;
            _stringCompareData = new StringCompareData(_detector, hamingThresold_, rContinuousThresold_, length_, stepsize_, useHaming_, useRContinuous_);

            _virusFolder = virusFolder_;
            _benignFolder = benignFolder_;

            _initialize();
        }

        public void stringCompareAnalysis()
        {
            // Read virus folder and benign folder
            // extract to all 32bit string
            // compute each string => get sum of result
            String[] virusFile = Directory.GetFiles(_virusFolder, "*.*", SearchOption.AllDirectories);
            String[] benignFile = Directory.GetFiles(_benignFolder, "*.*", SearchOption.AllDirectories);

            int virusLen = virusFile.Length;
            int benignLen = benignFile.Length;
            int totalLen = virusLen + benignLen;


            // Init for draw graph
            _graphMap = new double[totalLen][];


            int virusCount = 0;
            int benignCount = 0;
            int totalCount = 0;

            int randSize = 5;

            Random rand = new Random();

            while (!_done)
            {
                // 1. For virus
                int m = Math.Min(virusLen - virusCount, rand.Next(1, randSize + 1)); // +1 because Math.Min(a,b) means min from a to b-1
                m = virusLen;
                for (int i = 0; i < m; i++)
                {
                    _stringCompareData.Compute(virusFile[virusCount]);
                    
                    // Calc graph map value
                    _graphMap[totalCount] = new double[3];
                    _graphMap[totalCount][0] = _stringCompareData.getRateWithTotalVirusFragment();
                    _graphMap[totalCount][1] = _stringCompareData.getRateWithTotalFileString();
                    _graphMap[totalCount][2] = Utils.Utils.VIRUS_MARK;


                    virusCount++;
                    totalCount++;
                }

                // 2. lay so lan lap random cua sach nt
                int n = Math.Min(benignLen - benignCount, rand.Next(1, randSize + 1)); // +1 because Math.Min(a,b) means min from a to b-1
                n = benignLen;
                for (int j = 0; j < n; j++)
                {
                    _stringCompareData.Compute(benignFile[benignCount]);

                    // Calc graph map value
                    _graphMap[totalCount] = new double[3];
                    _graphMap[totalCount][0] = _stringCompareData.getRateWithTotalVirusFragment();
                    _graphMap[totalCount][1] = _stringCompareData.getRateWithTotalFileString();
                    _graphMap[totalCount][2] = Utils.Utils.BENIGN_MARK;


                    benignCount++;
                    totalCount++;
                }

                if (totalCount >= totalLen)
                    break;
            }
        }

        public void stopStringCompareAnalysis()
        {
            _done = true;
        }
    }
}
