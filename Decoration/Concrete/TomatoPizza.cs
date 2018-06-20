using Decoration.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decoration.Concrete
{
    class TomatoPizza : IPizza
    {

        public string DoPizza()
        {
            return "I'm a Tomato Pizza";
        }
    }
}
