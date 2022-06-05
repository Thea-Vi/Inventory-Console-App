using System;

namespace Inheritance_Interface_MiniProject
{
    //ExcavatorModel inherits InventoryItemModel  
    //ExcavatorModel implements interface IPurchaseable, and interface IRentable
    public class ExcavatorModel : InventoryItemModel, IRentable
    {
        public void Dig()
        {
            Console.WriteLine("I am digging.");
        }
        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This excavator has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("The excavator has been returned.");
        }
    }
}