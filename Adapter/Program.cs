using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /* This pattern enables the system to use the classes whose interface dont match with its requirement.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            double result1 =  adaptee.GetNumber(5, 3);

            Console.WriteLine(result1);

            ITarget target = new Adapter();
           int result= target.SpecificRequest(5, 3);
           Console.WriteLine(result);
           Console.ReadLine();
        }
    }
}
