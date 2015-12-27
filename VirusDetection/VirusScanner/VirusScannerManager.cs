using AForge.Neuro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirusDetection.Clustering;

namespace VirusDetection.VirusScanner
{
    class VirusScannerManager
    {
        LKDistanceNetwork _distanceNetwork;
        ActivationNetwork _activationNetwork;
        public VirusScannerManager()
        {

        }

        public VirusScannerManager(LKDistanceNetwork distanceNetwork_, ActivationNetwork activationNetwork_)
        {
            _distanceNetwork = distanceNetwork_;
            _activationNetwork = activationNetwork_;
        }

        public int scanFile(String fileName_)
        {
            return 0;
        }
    }
}
