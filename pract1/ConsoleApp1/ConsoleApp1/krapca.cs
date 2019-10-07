using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class krapca
    {
        protected int coordinateX;
        protected int coordinateY;
        protected int newcoordinateX;
        protected int newcoordinateY;
        
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public int NewCoordinateX { get; set; }
        public int NewCoordinateY { get; set; }
        public  krapca(int coordinateX, int coordinateY, int newcoordinateX, int newcoordinateY)
        {


            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.newcoordinateX = newcoordinateX;
            this.newcoordinateY = newcoordinateY;
            for (int i = 0; i < this.coordinateY; i++)
            {

                Console.WriteLine(" ");
                if(i+1 == coordinateY)
                {
                    for (int j = 0; j < this.coordinateX + 1; j++)
                    {
                        Console.Write(" ");
                        if (j == coordinateX)
                        {
                            Console.Write(".");
                        }
                    }
                    
                }
            }
            
            this.coordinateX += this.newcoordinateX;
            this.coordinateY += this.newcoordinateY;
            for (int i = 0; i < this.coordinateY; i++)
            {

                Console.WriteLine(" ");
                if (i + 1 == coordinateY)
                {
                    for (int j = 0; j < this.coordinateX + 1; j++)
                    {
                        Console.Write(" ");
                        if (j == coordinateX)
                        {
                            Console.Write(".");
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Output new coordinate");
            Console.WriteLine($"{ this.coordinateX}  { this.coordinateY}");

        }

    }
}
