using AForge.Neuro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirusDetection.Clustering;
using VirusDetection.FileClassifier;

namespace VirusDetection.VirusScanner
{
    class VirusScannerManager
    {
        LKDistanceNetwork _distanceNetwork;
        ActivationNetwork _activationNetwork;
        int[] _formatRange;
        public VirusScannerManager()
        {

        }

        public VirusScannerManager(LKDistanceNetwork distanceNetwork_, ActivationNetwork activationNetwork_, String formatRange_)
        {
            _distanceNetwork = distanceNetwork_;
            _activationNetwork = activationNetwork_;
            _formatRange = Utils.Utils.calcFormatRange(formatRange_);
        }

        public double scanFile(String fileName_)
        {

            FileClassifierData data = new FileClassifierData(_distanceNetwork, fileName_, _formatRange);
            double[] formatData = data.getFormatData();
            double[] result = _activationNetwork.Compute(formatData);
            return result[0];
        }
    }
}
