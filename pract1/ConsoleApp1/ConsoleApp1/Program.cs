using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Knopca");
            int[] krapcses = Console.ReadLine().Split().Select(int.Parse).ToArray();            
            int coordinateX = krapcses[0];
            int coordinateY = krapcses[1];
            int newcoordinateX = krapcses[2];
            int newcoordinateY = krapcses[3];
            krapca krapcese = new krapca(coordinateX, coordinateY, newcoordinateX, newcoordinateY);
            Console.WriteLine("Enter Radius");
            int radd = int.Parse(Console.ReadLine());
            int nradd = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Circle with point sector");
            int [] krapcses1 = Console.ReadLine().Split().Select(int.Parse).ToArray();            
             coordinateX = krapcses1[0];
             coordinateY = krapcses1[1];
             newcoordinateX = krapcses1[2];
             newcoordinateY = krapcses1[3];
            Circle circle = new Circle(coordinateX, coordinateY, newcoordinateX, newcoordinateY, radd, nradd);
            int point1 = krapcses1[4];
            int point2 = krapcses1[5];
            int newpoint1 = krapcses1[6];
            int newpoint2 = krapcses1[7];
            Sector sector = new Sector(coordinateX, coordinateY, newcoordinateX, newcoordinateY, point1, point2, newpoint1, newpoint2);
        
            
        }
    }
}
