﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylibrary
{
    class FlyNoWay:IFlyBehavior
    {
        public string Fly()
        {
            return "" + this.GetType();
        }
    }
}