﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPixelControl
{
    public class Frame
    {
        public List<Pixel> Pixels { get; set; }

        public int Delay { get; set; }

        public Frame(List<Pixel> pixels, int delay)
        {
            Pixels = pixels;
            Delay = delay;
        } 
    }
}
