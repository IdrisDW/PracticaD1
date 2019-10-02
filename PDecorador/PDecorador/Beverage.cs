using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDecorador
{
    public abstract class Beverage
    {
        
        public virtual string GetDescription()

        {

            return "Unknown Beverage";

        }

        public abstract double Cost();

    }
}
