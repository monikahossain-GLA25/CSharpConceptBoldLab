using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConceptBoldLab.Generic
{
    public class Student<T>
    {
        public T DATA;

        public Student(T data)
        {
            DATA = data;
            Console.WriteLine($"Student data: {DATA}");
        }

      
    }
}
