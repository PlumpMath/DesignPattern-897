using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
       public abstract ILaptop CreateLaptop();
       public abstract IMouse CreateMouse();
    }

    public class HPFactory:AbstractFactory
    {

        public override ILaptop CreateLaptop()
        {
            return new HPLaptop();
        }

        public override IMouse CreateMouse()
        {
            return new HPMouse();
        }
    }

    public interface ILaptop
    {
        void Create();
    }
    public interface IMouse
    {
        void Create();
    }

    public class HPLaptop : ILaptop
    {
        public void Create()
        {
            Console.WriteLine("HP Laptop is created");
        }
    }

    public class HPMouse : IMouse
    {
        public void Create()
        {
            Console.WriteLine("HP mouse is created");
        }
    }

    public static class GetFactory
    {

        public static AbstractFactory GetFactoryObject(string type)
        {
            if (type == "HP")
            {
                return new HPFactory();
            }
            return null;
        }
        

    }


}
