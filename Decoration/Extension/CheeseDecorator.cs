using Decoration.Decorator;
using Decoration.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decoration.Extension
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string DoPizza()
        {
            return pizza.DoPizza() + " Cheese";
        }
    }
}
