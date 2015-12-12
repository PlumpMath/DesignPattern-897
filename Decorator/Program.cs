using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Decorator design pattern is used to add new state/behaviour to object dynamically.
 */

namespace Decorator

{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent component = new Component();
            Console.WriteLine(component.Operation());

            IComponent decoratorA = new DecoratorA(component);
            Console.WriteLine(decoratorA.Operation());

            IComponent decoratorB = new DecoratorB(decoratorA);
            Console.WriteLine(decoratorB.Operation());

            Console.ReadLine();
        }
    }
}
