using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirusDetection.Clustering;

namespace VirusDetection.FileClassifier
{
    class FileClassifierManager
    {
        String _virusFolder;
        String _benignFolder;
        LKDistanceNetwork _network;
        double[][] _input;
        public FileClassifierManager(String virusFolder_, String benignFolder_, LKDistanceNetwork network_)
        {
            _virusFolder = virusFolder_;
            _benignFolder = benignFolder_;
            _network = network_;
        }

        public void train()
        {
            // Init training set for ANN
            // 
            this.buildTrainingSet();

            // Create ANN

            // Train ANN

        }

        private void buildTrainingSet()
        {
            
        }


    }
}
