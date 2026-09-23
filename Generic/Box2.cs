using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConceptBoldLab.Generic
{
    internal class Box2 <T>
    {

        private T Content;

        public Box2(T initialValue)
        {
            Content = initialValue;
        }
        public void updateContent(T newvalue)
        {
            Content = newvalue;
            Console.WriteLine($"Content updated to: {Content}");
        }
        public T getContent()
        {
            return Content;
        }
    }
}
