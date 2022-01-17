using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController.Model
{
    // Parent Product
    public class Food : Product
    {

        public FoodTypes FoodType { get;  }

        public Food(int id, int prize, string productTypeName, string howTooUse, FoodTypes foodType): base(id, prize, productTypeName, howTooUse)   
        {
            FoodType= foodType;
        }
        // Examine, to show the product’s price and info
        public override string Examine()
        {
            return ($"Product name: {TypeName}, Prize: {Prize} sek, Food Type: {FoodType}.\r\n");
        }

        public override string Use()
        {
            return ($"How to use {TypeName}: {TextHowToUse}.\n");
        }
    }
}
