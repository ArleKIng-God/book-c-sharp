using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventImplementation
{
    public class Handler
    {
        public void OnDispatcherNameChange(object sender , NameChangeEventArgs args)
        {
            Console.WriteLine($"Ім'я диспетчера змінено на {args.Name}.");
        }
    }
}
