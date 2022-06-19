// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;
namespace CabInvoiceGenerator
{
    class program
    {
        static void main(string[] args)
        {
            Console.WriteLine("Welcome To Cab  Invoice generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoiceGenerator.CalculateFare(2, 0, 5);
            Console.WriteLine($"Fare: {fare}"):
}
    }
}
