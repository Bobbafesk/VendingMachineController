using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController.Model
{
    public abstract class Product
    {
        /*
        int idProduct = 0;
        int prize = 0;
        string typeName = "";
        string textHowToUse = "";
        */

        public int IdProduct { get; }
        public int Prize { get; }
        public string TypeName { get;}
        public string TextHowToUse { get; }


        public Product(int id, int prize, string productTypeName, string howTooUse)
        {
            this.IdProduct = id;
            this.Prize = prize;
            this.TypeName = productTypeName;
            this.TextHowToUse = howTooUse;
        }
      

        // Examine, to show the product’s price and info
        public abstract string Examine();

        //Use, to put the product to use once it has been purchased(output a string message how to use the product
        public abstract string Use();


    }
}
