using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConceptBoldLab.Struct
{
 public struct Point

    {
        public int x;
        public int y;

        public Point(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }
        public void Display()
        {
            Console.WriteLine("The value of x is : " + x + "  " + " The Value of y is : " + y);
        }

    }
    internal class pROGRAM
    {
        public static void Main(string[] args)
            {
            Point p1 = new Point(20,65);
            p1.Display();



            Point p2;
            p2.x = 1234;
            p2.y = 67;
            p2.Display();


            Point P3 = p1;
            P3.x = 90;
            p1.y = 4;

            P3.Display();
        }
    }
}
