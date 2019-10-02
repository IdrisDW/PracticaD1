using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDecorador
{
    public class Decaf : Beverage

    {

        public Decaf()

    { }



    public override double Cost()

    {

        return 1.05;

    }



    public override string GetDescription()

    {

        return "Decaf Coffee";

    }



}

}
