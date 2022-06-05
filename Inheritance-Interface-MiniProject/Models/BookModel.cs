using System;

namespace Inheritance_Interface_MiniProject
{
    //BookModel inherits InventoryItemModel  
    //Book model implements interface IPurchaseable
    public class BookModel : InventoryItemModel, IPurchaseable
    {
        public int NumOfPages { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This book has been purchased.");
        }
    }
}