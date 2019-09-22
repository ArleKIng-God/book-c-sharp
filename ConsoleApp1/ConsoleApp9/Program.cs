using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            string product = "";
            n = Convert.ToDouble(Console.ReadLine());
            switch (n)
            {
                case 1:
                    product = "Monday";
                    break;
                case 2:
                    product = "Tuesday";
                    break;
                case 3:
                    product = "Wednesday";
                    break;
                case 4:
                    product = "Thursday";
                    break;
                case 5:
                    product = "Friday";
                    break;
                case 6:
                    product = "Saturday";
                    break;
                case 7:
                    product = "Sunday";
                    break;
                default:
                    product = "not valid";
                    break;
            }
            Console.WriteLine(product);
            Console.ReadKey();
        }
    }
}
