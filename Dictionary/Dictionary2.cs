using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSharpConceptBoldLab.Dictionary
{
    public  class Dictionary2
    {
        public void Run()
        {
            Dictionary<int, string> Food = new Dictionary<int, string>();
            Food.Add(201, "Mango");
            Food.Add(202, "Apple");
            Food.Add(203, "Biriyani");

            foreach(KeyValuePair<int , string> insomeia in Food)
            {
                Console.WriteLine(insomeia.Key + "  " + " " + insomeia.Value);
            }

            // access items in a dictionary
            string name = Food[201];
            Console.WriteLine(name);

            Food[203] = "Pizza";
            foreach(KeyValuePair<int , string> item in Food)
            {
                Console.WriteLine(item.Key + item.Value);
            }

            Food.Remove(201);
            foreach (KeyValuePair<int, string> item in Food)
            {
                Console.WriteLine(item.Key + item.Value);
            }

        }
    }
}
