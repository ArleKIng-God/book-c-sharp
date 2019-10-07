using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class Sector : krapca
    {
        private int point1;
        private int point2;
        private int newpoint1;
        private int newpoint2;
        
        public int Point1 { get; set; }
        public int Point2 { get; set; }
        public int Newpoint1 { get; set; }
        public int Newpoint2 { get; set; }
        public Sector(int coordinateX, int coordinateY, int newcoordinateX, int newcoordinateY, int point1, int point2, int newpoint1, int newpoint2)
            :base(coordinateX, coordinateY, newcoordinateX, newcoordinateY)
        {            
            this.point1 = point1;
            this.point2 = point2;
            this.newpoint1 = newpoint1;
            this.newpoint2 = newpoint2;
            this.point1 += this.newpoint1;
            this.point2 += this.newpoint2;
            Console.WriteLine();
            Console.WriteLine("Output new coordinate Point in Sector");
            Console.WriteLine($"{ this.point1}  { this.point2}");
        }
    }
}
