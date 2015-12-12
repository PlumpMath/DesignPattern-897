using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{

    public interface IBridge
    {
         string SendMessage(string message);
    }

    public class Abstraction
    {
        IBridge _bridge;
        public Abstraction(IBridge bridge)
        {
            _bridge = bridge;
        }

        public string SendEmail(string message)
        {
           return _bridge.SendMessage(message);
        }
    }

    public class SMTPEmail : IBridge
    {
         public string SendMessage(string message)
        {
            return message;
        }
    }

    public class ThirdPartyEmail:IBridge
    {
       
        public string SendMessage(string message)
        {
            return message;
        }

    }

}
