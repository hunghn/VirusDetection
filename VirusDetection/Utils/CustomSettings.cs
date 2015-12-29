using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirusDetection.Utils
{
    public class CustomSettings
    {
        public static String VIRUS_FOLDER = @"..\..\TestVirus\Virus";
        public static String BENIGN_FOLDER = @"..\..\TestVirus\Benign";
        public static String DETECTOR_FILE  = @"..\..\TestVirus\Detector.txt";
        public static String MIX_DETECTOR_FILE = @"..\..\TestVirus\MixDetector.txt";
        public static String CLUSTERING_FILE  = @"..\..\TestVirus\Clustering.txt";
        public static String FILE_CLASSIFIER_FILE = @"..\..\TestVirus\FileClassifier.txt";
    }
}
