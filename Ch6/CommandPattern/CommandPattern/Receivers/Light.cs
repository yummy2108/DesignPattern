﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Receivers
{
    public class Light
    {
        public void On() => Console.WriteLine("Light is on");

        public void Off() => Console.WriteLine("Light is off");
    }
}
