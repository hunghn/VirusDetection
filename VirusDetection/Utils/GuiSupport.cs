﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirusDetection.Utils
{
    class GuiSupport
    {
        FormMain _gui;
        public GuiSupport(FormMain gui_)
        {
            _gui = gui_;
        }

        public void progressBarUpdate()
        {
            _gui.updateProgressBarCallBack();
        }

        internal void progressBarInit()
        {
            _gui.progressBarInitCallBack();
        }
    }
}
