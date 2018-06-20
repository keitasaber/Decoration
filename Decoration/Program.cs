using Decoration.Concrete;
using Decoration.Extension;
using System;

namespace Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            ChickenPizza chickenPizza = new ChickenPizza();
            TomatoPizza tomatoPizza = new TomatoPizza();

            CheeseDecorator cheeseDecorator = new CheeseDecorator(chickenPizza);
            Console.WriteLine(cheeseDecorator.DoPizza());

            PepperDecorator pepperDecorator = new PepperDecorator(cheeseDecorator);
            Console.WriteLine(pepperDecorator.DoPizza());

            Console.ReadKey();
        }
    }
}
