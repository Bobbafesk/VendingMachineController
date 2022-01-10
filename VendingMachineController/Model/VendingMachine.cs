using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController.Model
{
    class VendingMachine : IVending
    {
        // There shall be following denominations 1kr, 5kr, 10kr, 20kr, 50kr, 100kr, 500kr and 1000kr
        // In this program you will send in the denomination in the constructor { 1, 5, 10, 20, 50, 100, 500, 1000}

        private  const int dominationSize = 8; // Idea was to use as input to array allDomination, but it want the int as const?
        public readonly int[] allDomination = new int[dominationSize];
        private int amountMoney=0; 
        public int Id { get; }
        public List<Product> productlist;


        public VendingMachine(int[] setDomination)        
        {
            this.allDomination = setDomination;
        }

        // EndTransaction, returns money left in appropriate amount of change.
        public int[] EndTransaction()
        {
            throw new NotImplementedException();
        }

        // InsertMoney, add money to the pool.
        public void InsertMoney(int money)
        {
            throw new NotImplementedException();

        }
        // Purchase, to buy a product.
        public Product Purchase(int id)
        {
            throw new NotImplementedException(); ;
        }

        // ShowAll, show all products.
        public List<Product> ShowAll()
        {
            throw new NotImplementedException();
        }
    }
}
