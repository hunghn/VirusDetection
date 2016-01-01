﻿using AForge;
using AForge.Neuro;
using AForge.Neuro.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirusDetection.Clustering;
using VirusDetection.Utils;

namespace VirusDetection.Clustering
{
    class ClusteringManager
    {
        
        int _numInputNeuron;
        private int _networkWidth;
        private int _networkHeight;
        private double _learningRate;
        private double _learningRadius;
        private int _numOfIterator;
        private double _errorThresold;

        LKDistanceNetwork _network;
        double[][] _input;
        float _maxInputRange;



        public int NumInputNeuron
        {
            get { return _numInputNeuron; }
            set { _numInputNeuron = value; }
        }

        public int NumOutputNeron
        {
            get 
            {
                if (_network != null)
                    return _network.Layers[0].Neurons.Length;

                return _networkWidth * _networkHeight;
            }
        }

        internal LKDistanceNetwork DistanceNetwork
        {
            get { return _network; }
            set { _network = value; }
        }

        public ClusteringManager()
        {
            _input = new double[0][];
            _numInputNeuron = 0;
            _maxInputRange = 0;
            _networkWidth = 0;
            _networkHeight = 0;
            _numOfIterator = 0;
            _errorThresold = 0;
        }

        public ClusteringManager(int inputCount_, int networkWidth_, int networkHeight_, double learningRate_, double learningRadius_, int numOfIterator_, double errorThresold_, double[][] input_, float maxInputRange_)
        {
            _numInputNeuron = inputCount_;
            _networkWidth = networkWidth_;
            _networkHeight = networkHeight_;
            _learningRate = learningRate_;
            _learningRadius = learningRadius_;
            _numOfIterator = numOfIterator_;
            _errorThresold = errorThresold_;

            _input = input_;
            _maxInputRange = maxInputRange_;
        }

        public void trainDistanceNetwork()
        {
            
            // Set random range
            Neuron.RandRange = new Range(0, _maxInputRange);

            // Create network
            _network = new LKDistanceNetwork(_numInputNeuron, _networkWidth * _networkHeight);

            // create learning algorithm
            LKSOMLearning trainer = new LKSOMLearning(_network, _networkWidth, _networkHeight);

            double fixedLearningRate = _learningRate / 10;
            double driftingLearningRate = fixedLearningRate * 9;

            // iterations
            int i = 0;

            bool done = false;
            // loop
            while (!done)
            {
                trainer.LearningRate = driftingLearningRate * (_numOfIterator - i) / _numOfIterator + fixedLearningRate;
                trainer.LearningRadius = (double)_learningRadius * (_numOfIterator - i) / _numOfIterator;

                // run training epoch
                double error = trainer.RunEpoch(_input);
                Console.WriteLine("Error: " + error);
                // update map
                //UpdateMap(network);

                // increase current iteration
                i++;


                // stop ?
                if (i >= _numOfIterator || error<=_errorThresold)
                    break;
            }

            trainer.mapNeuronLabel(_input);

        }

        public void saveDistanceNetwork(String fileName_)
        {
            Utils.Utils.saveNetwork(_network,fileName_);
        }

        public void loadDistanceNetwork(String fileName_)
        {
            _network = (LKDistanceNetwork)Utils.Utils.loadNetwork(fileName_);
            
            _numInputNeuron = _network.InputsCount;
        }

        #region Test Method
        public void testData(double[][] testDB)
        {
            foreach (double[] items in testDB)
            {
                int winner = testData(items);
                _println(items, winner);
            }
        }

        private void _println(double[] items, int winner)
        {
            foreach (double item in items)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("==> " + winner);
        }

        public void printlnNeuron()
        {
            ((LKDistanceLayer)_network.Layers[0]).printNeuron();
        }

        public int testData(double[] vector)
        {
            _network.Compute(vector);
            int winner = _network.GetWinner();
            return winner;
        }
        #endregion

        
        
    }
}
