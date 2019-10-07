using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class Circle : krapca 
    {
        private int coordinateX;
        private int coordinateY;
        private int newcoordinateX;
        private int newcoordinateY;
        private int r;
        private int newR;
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public int NewCoordinateX { get; set; }
        public int NewCoordinateY { get; set; }
        public int R
        {
            get { return r; }
            set { r = value; }
        }
        public int NewR { get; set; }
        
        public Circle(int coordinateX, int coordinateY, int newcoordinateX, int newcoordinateY, int radd, int newradd)
            :base (coordinateX, coordinateY, newcoordinateX, newcoordinateY)
        {
            
            
            this.r = radd;
            
            this.newR = newradd;            
            this.r += this.newR;
            int rad = this.r;
            Console.WriteLine();
            Console.WriteLine("Output new coordinate radius");            
            Console.WriteLine(rad);
        }
    }
}
