using System;
using SolidPrinciples.DIP.Solution;

namespace SolidPrinciples.DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(new EmailLogger());
            customer.Add();
        }
    }
}
