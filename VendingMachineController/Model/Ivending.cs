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
        public string ShowAll();

        // InsertMoney, add money to the pool. If not valid denomination it will retrun false
        public bool InsertMoney(int money);

        // EndTransaction, returns money left in appropriate amount of change.
        public List<int> EndTransaction();
    }
}
