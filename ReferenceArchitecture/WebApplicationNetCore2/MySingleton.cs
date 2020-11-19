using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationNetCore2
{

    public interface IMySingleton
    {
        void DoSomething();
    }
    public class MySingleton : IMySingleton
    {
        public void DoSomething()
        {
            Console.WriteLine("...");
        }
    }
}
