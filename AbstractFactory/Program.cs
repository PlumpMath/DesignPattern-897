using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory abstractFactory = GetFactory.GetFactoryObject("HP");
            ILaptop laptop = abstractFactory.CreateLaptop();
            IMouse mouse = abstractFactory.CreateMouse();
            laptop.Create();
            mouse.Create();
            Console.ReadLine();
        }
    }
}
