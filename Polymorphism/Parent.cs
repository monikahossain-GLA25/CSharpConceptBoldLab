using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConceptBoldLab.Polymorphism
{
    public class Parent
    {
        public virtual  void Baseclass()
        {
            Console.WriteLine("This is a Base Class");
        }
    }
    public class SubCLass1 : Parent
    {
        public override void Baseclass()
        {
            Console.WriteLine("This is a Sub class1");
        }
    }
    public class SubClass2 : Parent
    {
        public override void Baseclass()
        {
            Console.WriteLine("This is a Sub class2");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Parent p = new Parent();
            p.Baseclass();

            Parent a = new SubCLass1();
            a.Baseclass();

            Parent b = new SubClass2();
            b.Baseclass();  
        }
    }
}
