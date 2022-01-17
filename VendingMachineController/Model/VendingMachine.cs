using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController.Model
{
    class VendingMachine : IVending
    {
        // There shall be following denominations 1kr, 5kr, 10kr, 20kr, 50kr, 100kr, 500kr and 1000kr
        
        public readonly int[] allDomination; // {1000, 500, 100, 50, 20, 10, 5, 1}
        static private int vendingMoney=0;
        // static private int insertedMoney = ;
        static int idCounter = 0;
        //private int change = 0;
        //public int Change { get; set; }

        //  public int Id { get; }
        public List<Product> productsList;


        // public VendingMachine(int[] setDomination, List<Product> setProducts)
        public VendingMachine(int[] setDomination)        
        {
            this.allDomination = setDomination;
            productsList = new List<Product>();
        }

        // add product overloaded for drink
        // Id 1 ,prize 12, "Pripps", "Open can -> drink it",  carbonated: true
        public Product CreateProcuct( int prize, string productName, string howToUse, bool carbonated )
        {
            Drink newDrink = new Drink(++idCounter, prize, productName, howToUse, carbonated);
            return newDrink;
        }

        public void AddProducts(params Product[] products)
        { 
            if (products == null)
            {
                return;
            }
            foreach (Product product in products)
            {
                product.IdProduct = ++idCounter;
                productsList.Add(product);
            }
        }

        // EndTransaction, returns money left in appropriate amount of change.
        public List<int> EndTransaction()
        {
            List<int> changeList = new List<int>();
            if (vendingMoney== 0)
            {
                changeList.Add(0);
                return changeList;
            }
            for (int i=0; i<allDomination.Length; i++)
            {
                int domination = allDomination[i];
                while (vendingMoney >= domination)
                {
                    changeList.Add(domination);
                    vendingMoney -= domination;
                }
               
            }
            return changeList;
        }

        // InsertMoney, add money to the pool and return true. If not valid denomination it will retrun false

        public bool InsertMoney(int inMoney)
        {
            if (CheckValidDomination(inMoney) )
            {
                vendingMoney += inMoney;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckValidDomination(int money)
        {
            for (int i=0; i < allDomination.Length; i++)
            {
                if (money == allDomination[i])
                {
                    return true;
                }               
            }
            return false;
        }

        // Purchase, to buy a product.
        public Product Purchase(int id)
        {
            int prize = 0;
            
            foreach (Product prod in productsList)
            {
                if (prod.IdProduct == id)
                {
                    prize = prod.Prize;

                    if (vendingMoney>= prize)
                    {
                        vendingMoney -= prize;
                        return prod;
                    }
                    else
                    {   // Not enough money in machine.
                        // Shall implement throw =>  My exeption
                        return null;
                    }
         
                }
            }
            // No produkt with that id
            // Shall implement throw =>  My exeption
            return null;
        }

        // ShowAll, show all products.
        public string ShowAll()
        {
            //throw new NotImplementedException();
            string outString = "";
            foreach(Product product in productsList)
            {
                outString += product.ToString();
            }
            return outString;
        }
    }
}
