using Decoration.Decorator;
using Decoration.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decoration.Extension
{
    class PepperDecorator : PizzaDecorator
    {
        public PepperDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string DoPizza()
        {
            return pizza.DoPizza() + " pepper";
        }
    }
}
