﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDecorador
{
    public class Mocha : CondimentDecorator

    {

        Beverage beverage;



        public Mocha(Beverage beverage)

        {

            this.beverage = beverage;

        }



        public override string GetDescription()

        {

            return beverage.GetDescription() + ", Mocha";

        }



        public override double Cost()

        {

            return .20;

        }

 

    }

}