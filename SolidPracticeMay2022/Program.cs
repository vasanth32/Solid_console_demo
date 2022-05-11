using System;

namespace SolidPracticeMay2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Not LiskovSubstitution
            //Apple apple = new Orange();
            //Console.WriteLine(apple.GetColor());

            //LiskovSubstitution
            //Fruit fruit = new Oranges();
            //Console.WriteLine(fruit.GetColor());
            //fruit = new Apples();
            //Console.WriteLine(fruit.GetColor());

            //OpenClose
            InvoiceOC FInvoice = new FinalInvoice();
            InvoiceOC PInvoice = new ProposedInvoice();
            InvoiceOC RInvoice = new RecurringInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
            Console.ReadKey();
        }
    }
}
