using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConceptBoldLab.Polymorphism
{
    public class Payment
    {
        public virtual void ProcessPayment()
        {
            Console.WriteLine("Processing general payment.");

        }
        public virtual void PrintReceipt()
        {
            Console.WriteLine("Payment receipt");
        }
    }
    public class CashPayment : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Cash payment processed.");
        }

        
    }
    public class CardPayment : Payment
    {
        public override void PrintReceipt()
        {
            base.PrintReceipt();
            Console.WriteLine("Payment method: Card");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Payment payment1 = new Payment();
            payment1.ProcessPayment();

            Payment payment2 = new Payment();
            payment2.ProcessPayment();

            Payment obj = new CashPayment();
            obj.ProcessPayment();

            CardPayment card = new CardPayment();
            card.PrintReceipt();

        }
    }

}
