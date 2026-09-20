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
        }
    }
}
