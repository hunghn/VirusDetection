using AForge.Neuro;
using AForge.Neuro.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirusDetection.Clustering;

namespace VirusDetection
{
    class LKSOMLearning : SOMLearning
    {
        // neural network to train
        private LKDistanceNetwork network;

        public LKSOMLearning( LKDistanceNetwork network ):base(network)
        {
            // ok, we got it
            this.network = network;
        }

        public LKSOMLearning( LKDistanceNetwork network, int width, int height ):base(network,width,height)
        {
            this.network = network;
        }

        public void beginRunLKSOM()
        {
            _resetLKNeuronMap();
        }

        public void endRunLKSOM()
        {

        }

        private void _resetLKNeuronMap()
        {
            Layer layer = network.Layers[0];
            foreach (LKDistanceNeuron item in layer.Neurons)
            {
                item.resetLabel();
            }
        }

        public void mapNeuronLabel(double[][] input, int mappingDataIndex=-1)
        {
            if (mappingDataIndex == -1)
                mappingDataIndex = input.GetLength(1) - 1;
            int len = input.GetLength(0);
            LKDistanceLayer layer = (LKDistanceLayer)network.Layers[0];
            LKDistanceNeuron[] neurons = (LKDistanceNeuron[])layer.Neurons;
            for ( int i = 0; i < len; i++ )
			{
				network.Compute( input[i] );
				int w = network.GetWinner( );
                if (Utils.Utils.checkVirus(input[i][mappingDataIndex]))
                    neurons[w].detectVirus();
                else
                    neurons[w].detectBenign();
			}
        }

    }
}
