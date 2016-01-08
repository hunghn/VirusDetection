using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirusDetection.Utils
{
    public class CustomSettings
    {
        public static String TEST_FOLDER = @"..\..\TestData\";

        public static String VIRUS_FOLDER = TEST_FOLDER+@"\TestVirus\Virus\";
        public static String BENIGN_FOLDER = TEST_FOLDER + @"\TestVirus\Benign\";
        public static String TEST_FILE_FOLDER = TEST_FOLDER + @"\TestVirus\TestFile\";

        public static String DETECTOR_FILE = TEST_FOLDER + @"\TestVirus\Detector.txt";
        public static String MIX_DETECTOR_FILE = TEST_FOLDER + @"\TestVirus\MixDetector.txt";
        public static String CLUSTERING_FILE = TEST_FOLDER + @"\TestVirus\Clustering.txt";
        public static String FILE_CLASSIFIER_FILE = TEST_FOLDER + @"\TestVirus\FileClassifier.txt";
    }
}
