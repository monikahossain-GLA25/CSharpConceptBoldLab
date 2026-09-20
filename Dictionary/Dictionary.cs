using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConceptBoldLab.Dictionary
{
    public class Dictionary
    {
        public void RUN()
        {
            Dictionary<string, int> Employess = new Dictionary<string, int>()
            {
                {
                    "Monika" , 10
                },
                {
                    "Rohit" , 20
                },
                {
                    "Sandeep" , 30
                },
                {
                    "Ramesh" , 40
                }
            };
            foreach (KeyValuePair<string, int> item in Employess)
            {
                Console.WriteLine($"Key : {item.Key} , Value : {item.Value}");
            }
          bool A =  Employess.ContainsKey("Monika");
            Console.WriteLine($"Is Monika is present in the dictionary : {A}");
            string s = Employess["Monika"].ToString();
            Console.WriteLine($"Value of Monika is : {s}");

            Employess.Add("mARIAM ", 50);
            foreach (KeyValuePair<string, int> item in Employess)
            {
                Console.WriteLine($"Key : {item.Key} , Value : {item.Value}");
            }


        }
        public static void Main(string[] args)
        {
            Dictionary obj = new Dictionary();
            obj.RUN();

        }
    }
}
