using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController.Model
{
    //class Product is parent Children Drink, Food, Toy 
    public class Drink: Product
    {
        public string Carbonated { get; set; }

        // T ex (serial number 1 , 12, "Pripps", "Open can -> drink it", "it is carbonated")
        // T ex (serial number 2, 11, "Önos saft", "open bottle -> drink it", "not carbonated")
        public Drink(int id, int prize, string productTypeName, string howTooUse, string carbonated) : 
                                    base(id, prize, productTypeName, howTooUse)
        {
            this.Carbonated = carbonated;
        }

        // Examine, to show the product’s price and info
        public override string Examine()
        {
            return ($"Prize {Prize} sek.\r\n" + Use());
        }

        public override string Use()
        {
            return ($"How to use {TypeName}: {TextHowToUse}." );
        }
    }
}
