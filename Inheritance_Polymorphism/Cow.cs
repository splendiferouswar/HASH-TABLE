﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Polymorphism
{
    class Cow : Animal
    {
        /*there are 2 cow constructors with the same name but there are differnt parameters to the constructors
        the first constructor takes in cow vaccination cost but since jersey cow inherits from cow we do not want a jersey cow to also inherit cow vaccination cost*/
        public Cow(int id, double milkQty, string animalType) : base(id, milkQty, animalType)
        {
        }
      
        public override double getProfit() //We need to override because we have a same name with parent class and the parent class method will be replaced with this
        {
            double getProfit = ((Costs.cowMilkPriceUserInput * milkQty)* 365) - (Costs.userInputCowVax);
            return getProfit;
        }
    }
}
