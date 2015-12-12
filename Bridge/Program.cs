using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{

    /*The bridge design pattern decouples abstraction from its implementation. This design pattern
     is useful when new version of software is brough down but old version of functionality will still be used by
     existing clients.*/
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction obj = new Abstraction(new SMTPEmail());
            Console.WriteLine(obj.SendEmail("This email will be sent by SMTP"));

            obj = new Abstraction(new ThirdPartyEmail());
            Console.WriteLine(obj.SendEmail("This email will be sent by Third party"));
            Console.ReadLine();
            
        }
    }
}
