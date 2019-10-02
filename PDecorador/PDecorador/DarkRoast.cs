using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDecorador
{
    public class DarkRoast : Beverage

    {

        public DarkRoast()

        { }



        public override double Cost()

        {

            return .99;

        }



        public override string GetDescription()

        {

            return "Dark Roast Coffee";

        }



    }

}