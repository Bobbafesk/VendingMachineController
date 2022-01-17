using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController.Model
{
    public class Toy: Product
    {
        public ToyTypes ToyType { get; }

        public Toy(int id, int prize, string productTypeName, string howTooUse, ToyTypes toyType) : 
                    base(id, prize, productTypeName, howTooUse)
        {
            this.ToyType = toyType;
        }

        public override string Examine()
        {
            return ($"Product name: {TypeName}, Prize: {Prize} sek, Toy Type: {ToyType}.\r\n");
        }

        public override string Use()
        {
            return ($"How to use {TypeName}: {TextHowToUse}.\n");
        }
    }
}
