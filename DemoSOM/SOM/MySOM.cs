using AForge;
using AForge.Neuro;
using AForge.Neuro.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSOM.SOM
{
    class MySOM
    {
        double[][] _input;
        int[, ,] map;
        DistanceNetwork _network;

        private int networkSize = 2;
        private int iterations = 500;
        private double learningRate = 0.3;
        private int learningRadius = 3;

        public MySOM(double[][] input_)
        {
            _input = input_;
        }

        public void TrainNetwork()
        {
            
            // Set random range
            Neuron.RandRange = new Range(0, 100);

            // Create network
            _network = new DistanceNetwork(1, networkSize * 1);

            // create learning algorithm
            SOMLearning trainer = new SOMLearning(_network, networkSize, 1);

            // create map
            map = new int[2, 1, 3];

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
            Console.WriteLine("==> "+winner);
        }

        public int testData(double[] vector)
        {
            _network.Compute(vector);
            int winner = _network.GetWinner();
            return winner;
        }
        
    }
}
