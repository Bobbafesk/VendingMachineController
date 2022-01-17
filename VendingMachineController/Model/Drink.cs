using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController.Model
{
    //class Product is parent. Children: Drink, Food, Toy 
    public class Drink: Product
    {
        public bool Carbonated { get; set; }

        // T ex (serial number 2, 11, "Önos saft", "open bottle -> drink it", "not carbonated")
        public Drink(int id, int prize, string productTypeName, string howTooUse, bool carbonated) : 
                                    base(id, prize, productTypeName, howTooUse)
        {
            this.Carbonated = carbonated;
        }

        // Examine, to show the product’s price and info
        public override string Examine()
        {
            string carbText = Carbonated ? "is carbonated" : "not carbonated";
            return ($"Product name: {TypeName}, Prize: {Prize} sek, Drink Type: {carbText}.\r\n");
        }

        public override string Use()
        {
            return ($"How to use {TypeName}: {TextHowToUse}.\n" );
        }
    }
}
