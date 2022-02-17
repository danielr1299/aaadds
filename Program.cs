using DataStuctures;
using Logic;
using System;

namespace UI
{
    class Program
    {
        static void PrintInt(double item)
        {
            Console.WriteLine(item);
        }
        static void Main(string[] args)
        {
            //Manager m = new Manager(new Comunicator(), 300);
            BST<double> x = new BST<double>();
            x.AddY(3);
            x.AddY(4);
            x.AddY(5);
            x.AddY(6);
            x.AddY(1);
            x.ScanInOrder(PrintInt);

            Console.WriteLine(x);
        }
    }
}
