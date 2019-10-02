using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDecorador
{
    public class Expresso : Beverage

    {

        public Expresso()

        { }



        public override double Cost()

        {

            return 1.5;

        }



        public override string GetDescription()

        {

            return "Expresso";

        }

 


    }

}