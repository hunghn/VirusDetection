using AForge.Neuro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirusDetection.Clustering
{
    [Serializable]
    class LKDistanceNetwork : DistanceNetwork
    {
        public LKDistanceNetwork( int inputsCount, int neuronsCount )
            : base( inputsCount, 1 )
        {
            // create layer
            layers[0] = new LKDistanceLayer( neuronsCount, inputsCount );
        }
    }
}
