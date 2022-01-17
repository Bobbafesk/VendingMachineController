using System;
using static System.Console;
using VendingMachineController.Model;
using System.Collections.Generic;

namespace VendingMachineController
{
    class Program
    {
        static void Main(string[] args)
        {
            Product purshaseProduct = null;
            Product sut1 = new Drink(4, 42, "Pripps", "Open can -> drink it", true);
            Product sut2 = new Drink(4, 12, "Önos", "Open bottle -> drink it", false);
            Product sut3 = new Drink(3, 13, "Kaffe", "Open can -> drink it", false);
            Product sut4 = new Drink(4, 14, "Champis", "Open bottle -> drink it", true);
            Product sut5 = new Drink(5, 7, "Ramlösa", "Open can -> drink it", true);
            Product sut6 = new Food(5, 78, "Meatloaf", "Open can -> eat it", FoodTypes.Meat);
            Product sut7 = new Food(5, 93, "Chicken nuggets", "Open bag -> eat it", FoodTypes.Chicken);
            Product sut8 = new Food(5, 66, "Cod", "Open can -> eat it", FoodTypes.Fisch);
            Product sut9 = new Food(5, 62, "Salad", "Open plastic bag -> eat it", FoodTypes.Vegetarian);
            Product sut10 = new Toy(5, 346, "Boba Fett", "Open plastic bag -> Play with it", ToyTypes.StarWars);
            Product sut11 = new Toy(5, 252, "Ninjago warior", "Open plastic bag -> Play with it", ToyTypes.Lego);
            Product sut12 = new Toy(5, 175, "Barbie", "Open plastic bag -> Play with it", ToyTypes.Doll);
            Product sut13 = new Toy(5, 214, "Rabbit", "Open plastic bag -> Play with it", ToyTypes.SoftAnimal);

           
            int[] denominationList = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 };
           // VendingMachine myVend = new VendingMachine(denomList, productList);
            VendingMachine myVend = new VendingMachine(denominationList);
            myVend.AddProducts(sut1, sut2, sut3, sut4, sut5);
            myVend.AddProducts(sut6, sut7, sut8, sut9);
            myVend.AddProducts(sut10, sut11, sut12, sut13);
            Console.WriteLine("Func. Show all");
            string a = myVend.ShowAll();
            Console.WriteLine(a);

            Console.WriteLine("Insert money");
            myVend.InsertMoney(1000);
            myVend.InsertMoney(1000);
            myVend.InsertMoney(1000);
            myVend.InsertMoney(500);
            myVend.InsertMoney(50);
            myVend.InsertMoney(100);
            myVend.InsertMoney(20);
            myVend.InsertMoney(5);
            myVend.InsertMoney(1);
            myVend.InsertMoney(1);
            myVend.InsertMoney(1);
            myVend.InsertMoney(1);
            Console.WriteLine("End transaction");
            List<int> intList = myVend.EndTransaction();

            Console.WriteLine("Change: ");
            foreach (int item in intList)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine("\n\nTest of method Examine");
            Console.WriteLine(sut2.Examine());
            Console.WriteLine(sut9.Examine());
            Console.WriteLine(sut10.Examine());

            Console.WriteLine("Test of method Use");
            Console.WriteLine(sut2.Use());
            Console.WriteLine(sut9.Use());
            Console.WriteLine(sut10.Use());
            Console.WriteLine("Test of Purchase");
            Console.WriteLine(myVend.Purchase(10));
            Console.WriteLine(myVend.Purchase(50));
            myVend.InsertMoney(500);
            purshaseProduct =  myVend.Purchase(10);
            Console.WriteLine(purshaseProduct.Use());
            intList = myVend.EndTransaction();
            Console.WriteLine("Change: ");
            foreach (int item in intList)
            {
                Console.Write(item + ", ");
            }

        }
    }
}
