using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConceptBoldLab.Dictionary
{
    public class phonebook
    {
        public void Run()
        {
            Dictionary<string, long> phonebookDic = new Dictionary<string, long>();
            phonebookDic.Add("Monika", 1234567890);
            phonebookDic.Add("HosneaRA", 1234567890);
            phonebookDic["John"] = 9876543210;

            foreach(KeyValuePair<string, long> entry in phonebookDic)
            {
                Console.WriteLine($"Name: {entry.Key}, Phone Number: {entry.Value}");
            }


            if (phonebookDic.ContainsKey("Monika"))
            {
                Console.WriteLine($"Monika's phone number is: {phonebookDic["Monika"]}");
            }
            else
            {
                Console.WriteLine("Monika is not in the phonebook.");
            }
            phonebookDic.Remove("HosneaRA");
            Console.WriteLine("After removing HosneaRA:" + phonebookDic.Count + " entries in the phonebook.");

            foreach (KeyValuePair<string, long> entry in phonebookDic)
            {
                Console.WriteLine($"Name: {entry.Key}, Phone Number: {entry.Value}");
            }

        }
    }
}
