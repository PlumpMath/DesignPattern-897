using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adaptee
    {
        public double GetNumber(double a, double b)
        {
            return a / b;
        }
    }

    public interface ITarget
    {
         int SpecificRequest(double a, double b);
    }

    public class Adapter:Adaptee,ITarget
    {
               
        public int SpecificRequest(double a, double b)
        {
           return (int) Math.Round(GetNumber(a, b));
        }
    }
}
