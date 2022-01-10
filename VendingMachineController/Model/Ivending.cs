using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController.Model
{
    public interface IVending
    {
       
        // Purchase, to buy a product.
        public Product Purchase(int id);

        // ShowAll, show all products.
        public List<Product> ShowAll();

        // InsertMoney, add money to the pool.
        public void InsertMoney(int money);

        // EndTransaction, returns money left in appropriate amount of change.
        public int[] EndTransaction();
    }
}
