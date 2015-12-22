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

namespace DemoSOM.SOM
{
    class ClusteringManager
    {
        double[][] _input;
        float _inputRange;
        LKDistanceNetwork _network;

        private int _networkWidth = 2;
        private int _networkHeight = 2;
        private int iterations = 500;
        private double learningRate = 0.3;
        private int learningRadius = 3;

        public ClusteringManager(double[][] input_, float inputRange_, int networkWidth_, int networkHeight_)
        {
            _input = input_;
            _inputRange = inputRange_;
            _networkWidth = networkWidth_;
            _networkHeight = networkHeight_;
        }

        public void trainNetwork()
        {
            
            // Set random range
            Neuron.RandRange = new Range(0, _inputRange);

            // Create network
            _network = new LKDistanceNetwork(1, _networkWidth * _networkHeight);

            // create learning algorithm
            SOMLearning trainer = new SOMLearning(_network, _networkWidth, _networkHeight);

            double fixedLearningRate = learningRate / 10;
            double driftingLearningRate = fixedLearningRate * 9;

            // iterations
            int i = 0;

            bool done = false;
            // loop
            while (!done)
            {
                trainer.LearningRate = driftingLearningRate * (iterations - i) / iterations + fixedLearningRate;
                trainer.LearningRadius = (double)learningRadius * (iterations - i) / iterations;

                // run training epoch
                trainer.RunEpoch(_input);

                // update map
                //UpdateMap(network);

                // increase current iteration
                i++;


                // stop ?
                if (i >= iterations)
                    break;
            }



        }

        public void saveNetwork(String fileName_)
        {
            Utils.saveLKDistanceNetwork(_network,fileName_);
        }

        public void loadNetwork(String fileName_)
        {
            _network = Utils.loadLKDistanceNetwork(fileName_);
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

        public int testData(double[] vector)
        {
            _network.Compute(vector);
            int winner = _network.GetWinner();
            return winner;
        }
        #endregion

        
        
    }
}
