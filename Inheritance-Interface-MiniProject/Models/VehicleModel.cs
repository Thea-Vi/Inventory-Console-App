using System;

namespace Inheritance_Interface_MiniProject
{
    //VehicleModel inherits InventoryItemModel  
    //vehicle implements interface IPurchaseable, and interface IRentable
    public class VehicleModel : InventoryItemModel, IPurchaseable, IRentable
    {
        public decimal DealerFee { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This vehicle has been purchased.");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This vehicle has been rented.");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("This vehicle has been returned.");
        }
    }
}