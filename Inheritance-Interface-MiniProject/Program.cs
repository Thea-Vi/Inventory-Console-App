using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Interface_MiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //store the rentables items and purchaseable items in interface lists
            List<IRentable> rentables = new List<IRentable>();  
            List<IPurchaseable> purchaseables = new List<IPurchaseable>();

            var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Kia Optima" };
            var book = new BookModel { NumOfPages = 2500, ProductName = "Harry Potter" };
            var excavator = new ExcavatorModel { ProductName = "Bulldozer", QuantityInStock = 2 };

            rentables.Add(vehicle);
            rentables.Add(excavator);

            purchaseables.Add(book);
            purchaseables.Add(vehicle);

            Console.Write("Do you want to rent or purchase something? (rent, purchase)");
            string rentalDecision = Console.ReadLine();

            if (rentalDecision.ToLower() == "rent")
            {
                //loops through each item stored in rentables list
                foreach (var item in rentables)

                {
                    Console.WriteLine($"Item: { item.ProductName}");
                    Console.Write("Do you want to rent this item? (yes/no)");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }

                    Console.WriteLine("Do you want to return this item? (yes/no)");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }
            else
            {
                //loops though each item stored in purchaseables
                foreach (var item in purchaseables)
                {
                    Console.WriteLine($"Item: { item.ProductName }");
                    Console.WriteLine("Do you want to purchase this item? (yes/no)");
                    string wantToPurchase = Console.ReadLine();

                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }
                }
            }


            Console.WriteLine("We are done");
            Console.ReadLine();
        }
    }
}