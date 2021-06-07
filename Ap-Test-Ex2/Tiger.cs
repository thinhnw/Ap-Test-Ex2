﻿using System;
using System.Security.Permissions;

namespace Ap_Test_Ex2
{
    public class Tiger : Base
    {
        public Tiger() : base()
        {
        }

        public Tiger(double weight, string name) : base(weight, name)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Name: " + this.name + ", Weight " + this.weight);
        }

        public override void SetMe(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
    }
}