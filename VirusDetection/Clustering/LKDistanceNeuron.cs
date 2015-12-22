﻿using AForge.Neuro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirusDetection.Clustering
{
    [Serializable]
    class LKDistanceNeuron:DistanceNeuron
    {
        int _virusDetectedCount;
        int _benignDetectedCount;
        public LKDistanceNeuron(int inputs) : base(inputs) 
        {
            _initializeLK();
        }
        private void _initializeLK()
        {
            _benignDetectedCount = _virusDetectedCount = 0;
        }
        public void detectVirus()
        {
            _virusDetectedCount++;
        }
        public void detectBenign()
        {
            _benignDetectedCount++;
        }
        public int getClusterLable()
        {
           return (_virusDetectedCount > 0 ? 1 : 0)*2|(_benignDetectedCount > 0 ? 1 : 0); 
        }

        public void resetLabel()
        {
            _initializeLK();
        }

        public override double Compute(double[] input)
        {
            // check for corrent input vector
            if (input.Length < inputsCount)
                throw new ArgumentException("Wrong length of the input vector.");

            // difference value
            double dif = 0.0;

            // compute distance between inputs and weights
            for (int i = 0; i < inputsCount; i++)
            {
                dif += Math.Abs(weights[i] - input[i]);
            }

            // assign output property as well (works correctly for single threaded usage)
            this.output = dif;

            return dif;
        }
    }
}
