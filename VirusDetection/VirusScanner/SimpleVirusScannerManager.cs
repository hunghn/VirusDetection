using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirusDetection.Detector;
using VirusDetection.StringCompare;

namespace VirusDetection.VirusScanner
{
    class SimpleVirusScannerManager
    {
        double _thresold;
        private StringCompareData _stringCompareData;
        public SimpleVirusScannerManager()
        {
        }

        public SimpleVirusScannerManager(StringCompareManager stringCompareManager_, double thresold_)
        {
            _stringCompareData = stringCompareManager_.StringCompareData;
            _thresold = thresold_;
        }

        public Boolean scanFile(String fileName_)
        {
            // Doc file
            // Lay tung chuoi so sanh voi cac detector
            // Neu trung tang count
            // Tinh ti le
            // So sanh voi muc nguong va dua ra ket qua
            _stringCompareData.Compute(fileName_);
            double result = _stringCompareData.getRateWithTotalFileString();

            if (result >= _thresold)
                return true;
            return false;
        }
    }
}
