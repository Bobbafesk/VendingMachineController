using System;
using static System.Console;
using VendingMachineController.Model;

namespace VendingMachineController
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product sut = new Drink();
            // ( 1 , 12, "Pripps", "Open can -> drink it", "it is carbonated")
            Product sut2 = new Drink(1, 12, "Pripps", "Open can -> drink it", "carbonated");
            Console.WriteLine(sut2.Examine());
            ReadKey();
        }
    }
}
