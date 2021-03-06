using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController.Model
{
    //class Product is parent. Children: Drink, Food, Toy 
    public abstract class Product
    {

        // int idProduct = 0;
        // int prize = 0;
        private string typeName = "";
        private string textHowToUse = "";


        public int IdProduct { get; set; }
        public int Prize { get; }
        public string TypeName
        {
            get { return typeName; }
            // To check that the string is in good format
            set
            {
                if (CheckString(value))
                {
                    typeName = value;
                }
                else
                {
                    throw new ArgumentException("Null, emty or whitespace", "typeName");
                }
            }
        }
        public string TextHowToUse
        {
            get { return textHowToUse; }
            // To check that the string is in good format
            set
            {
                if (CheckString(value))
                {
                    textHowToUse = value;
                }
                else
                {
                    throw new ArgumentException("Null, emty or whitespace", "textHowToUse");
                }
            }
        }

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

        private bool CheckString(string toCheck)
        {
            if (String.IsNullOrWhiteSpace(toCheck))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            return $"Id: {IdProduct}, Name: {typeName}, Prize: {Prize} Sek.\n";
        }
    }
}
