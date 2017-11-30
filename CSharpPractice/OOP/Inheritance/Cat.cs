﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Cat : Animal
    {
        public string Said { get; set; }

        public override string SaySomething()
        {
            return $"Myauuu - {base.SaySomething()}";
        }
    }
}
