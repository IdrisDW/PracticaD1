using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDecorador
{
    public class SteamedMilk : CondimentDecorator

    {

        Beverage beverage;



        public SteamedMilk(Beverage beverage)

        {

            this.beverage = beverage;

        }



        public override string GetDescription()

        {

            return beverage.GetDescription() + ", Steamed Milk";

        }



        public override double Cost()

        {

            return .10 + beverage.Cost();

        }

    }

}