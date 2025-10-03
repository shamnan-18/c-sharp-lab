using System;
namespace payment
{
    interface Ipayment
    {
        public void Makepayment(double amount);
    }
    class Creditcard : Ipayment
    {
        public void Makepayment(double amount)
        {
            Console.WriteLine("INR {amount} done through credit card");
        }
    }
    class Paypal:Ipayment
    {
        public void Makepayment(double amount)
        {
            Console.WriteLine(amount + "done through paypal");
        }
        class UPI:Ipayment
        {
            public void Makepayment(double amount)
            {
                Console.WriteLine("INR" + amount+ "payment thrugh UPI");
            }
        }
        class Program
        {
            static void  Main()
        }
    }
}