using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDecorador
{
    public class HouseBlend : Beverage

    {

        public HouseBlend()

        { }



        public override double Cost()

        {

            return .89;

        }



        public override string GetDescription()

        {

            return "House Blend Coffee";

        }



    }

}
