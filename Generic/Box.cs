using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConceptBoldLab.Generic
{
    public class Box <T>
    {
        public T content { get; set; }

        public string Log()
        {
            return $"Box contains: {content}";
        }

        
    }
}
