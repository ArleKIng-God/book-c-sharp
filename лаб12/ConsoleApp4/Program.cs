using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventImplementation
{
    class Program
    {
        static void Main()
        {
            var dispatcher = new Dispatcher();
            var handler = new Handler();
            dispatcher.NameChange += handler.OnDispatcherNameChange;

            var name = Console.ReadLine();

            while (!name.Equals("End"))
            {
                dispatcher.Name = name;
                name = Console.ReadLine();
            }
        }
    }
}
