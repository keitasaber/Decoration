using Decoration.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decoration.Concrete
{
    class ChickenPizza : IPizza
    {
        public string DoPizza()
        {
            return "I am a Chicken Pizza";
        }
    }
}
