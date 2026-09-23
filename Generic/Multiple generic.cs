using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConceptBoldLab.Generic
{
    internal class MBox<TMB, TMR>
    {
        public TMB value1 { get; set; }
        public TMR value2 { get; set; }

        public MBox(TMB mb , TMR mr)
        {
            this.value1 = mb;
            this.value2 = mr;
        }
        public void Display()
        {
            Console.WriteLine(value1);
            Console.WriteLine(value2);
        }
    }
}
