using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface IComponent
    {
        string Operation();
    }

    public class Component : IComponent
    {
        public string Operation()
        {
            return "I am Walking ";
        }
    }

    public class DecoratorA : IComponent
    {
        IComponent _component;
        public DecoratorA(IComponent component)
        {
            _component = component;
        }
        public string Operation()
        {
            string s = _component.Operation() + " to my office ";
            return s;
        }
    }

    public class DecoratorB : IComponent
    {
        IComponent _component;
        public DecoratorB(IComponent component)
        {
            _component = component;
        }
        public string Operation()
        {
            string s = _component.Operation() + " with coffee ";
            return s;
        }
    }



}
