using CSharpConceptBoldLab.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConceptBoldLab.Generic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box<int> objBox = new Box<int>();
            objBox.content = 42;
            Console.WriteLine(objBox.Log());

            Box<string> strBox = new Box<string>();
            strBox.content = "Monik Hossain`";
            Console.WriteLine(strBox.Log());

            Box2<int> objBox2 = new Box2<int>(42);
            Console.WriteLine($"Content: {objBox2.getContent()}");


            //For Student class
            Student<string> objString = new Student<string>("Monika Robi");

            Student<int> objInt = new Student<int>(12345);

            //for multiple 
            MBox<string, int> objMBox = new MBox<string, int>("nAZAAA", 12);
            objMBox.Display();

            //Logger
            Logger objLogger = new Logger();
            objLogger.Log<int>(10);
            objLogger.Log<string>("Salsa");
            objLogger.Log(new { Name = "Monika", Age = 28 });



        }
    }
}
