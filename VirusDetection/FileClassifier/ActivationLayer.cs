// AForge Neural Net Library
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright � AForge.NET, 2007-2012
// contacts@aforgenet.com
//

namespace VirusDetection.FileClassifier
{
    using AForge.Neuro;
using System;

    /// <summary>
    /// Activation layer.
    /// </summary>
    /// 
    /// <remarks>Activation layer is a layer of <see cref="ActivationNeuron">activation neurons</see>.
    /// The layer is usually used in multi-layer neural networks.</remarks>
    ///
    [Serializable]
    public class LKActivationLayer : ActivationLayer
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivationLayer"/> class.
        /// </summary>
        /// 
        /// <param name="neuronsCount">Layer's neurons count.</param>
        /// <param name="inputsCount">Layer's inputs count.</param>
        /// <param name="function">Activation function of neurons of the layer.</param>
        /// 
        /// <remarks>The new layer is randomized (see <see cref="ActivationNeuron.Randomize"/>
        /// method) after it is created.</remarks>
        /// 
        public LKActivationLayer( int neuronsCount, int inputsCount, IActivationFunction function )
            : base( neuronsCount,  inputsCount,  function  )
        {
            // create each neuron
            for ( int i = 0; i < neurons.Length; i++ )
                neurons[i] = new LKActivationNeuron( inputsCount, function );
        }
    }
}
