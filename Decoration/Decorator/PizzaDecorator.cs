using Decoration.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decoration.Decorator
{
    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza pizza;

        public PizzaDecorator(IPizza p)
        {
            pizza = p;
        }

        public abstract string DoPizza();
    }
}
