﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Services.Display
{
    internal class SimpleDisplayBehavior : IDisplayBehavior
    {
        public void Display()
        {
            Console.WriteLine("Simple Display");
        }
    }
}
