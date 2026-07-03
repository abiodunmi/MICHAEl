using System;
using System.Collections.Generic;
using System.Text;

namespace MICHAEl
{
    internal class AddToCart
    {
        public int Id { get; set; }
        public string ItemsName { get; set; }
        public int Price { get; set; }

        public static void ViewProduct(List<AddToCart> Products)

        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Welcome to Add to Cart");
            Console.WriteLine("--------------------------");
            Console.WriteLine("These are the products available in the store");
            foreach (AddToCart prd in Products)
            {
                Console.WriteLine($"{prd.Id}. Name: {prd.ItemsName}. Price: {prd.Price}. ");
            }

        }

        public static void AdddProductToCart(List<AddToCart> Products, List<AddToCart> prdAddCarts)
        {
            Console.WriteLine("Add items to Cart");
            //int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Id of the product you want to add to the cart:");
            string myAns = "Y";
            while (myAns == "Y")
            {
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }
                AddToCart toCart = Products.FirstOrDefault(p => p.Id == choice);
                if (toCart != null)
                {
                    prdAddCarts.Add(toCart);
                    Console.WriteLine($"Product '{toCart.ItemsName}' added to the cart.");
                    Console.WriteLine("Add more items to the cart? Y/N");
                    myAns = Console.ReadLine().ToUpper();

                }
                else
                {
                    Console.WriteLine("Product not found in the cart.");

                }
            }
        }

        public static void ViewCart(List<AddToCart> prdAddCarts)
        {
            Console.WriteLine("Items in your cart:");
            if (prdAddCarts.Count == 0)
            {
                Console.WriteLine("Your cart is empty.");

            }
            double total = 0;
            foreach (AddToCart prd in prdAddCarts)
            {
                Console.WriteLine($"{prd.Id}. Name: {prd.ItemsName}. Price: {prd.Price}. ");
                total += prd.Price;
            }

            Console.WriteLine($"Total Price: {total}");
            Console.WriteLine($"Item: {prdAddCarts.Count}");

        }

        public static void RemovedProductToCart(List<AddToCart> Products, List<AddToCart> prdAddCarts)
        {
            Console.WriteLine("Remove items from Cart");
            //int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Id of the product you want to remove from the cart:");
            string myAns = "Y";
            while (myAns == "Y")
            {
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }
                AddToCart toCart = Products.FirstOrDefault(p => p.Id == choice);
                if (toCart == null)
                {
                    Console.WriteLine("Product not found in the cart.");

                }
                else
                {
                    prdAddCarts.Remove(toCart);
                    Console.WriteLine($"Product '{toCart.ItemsName}' removed from the cart.");
                    Console.WriteLine("Remove more items to the cart? Y/N");
                    myAns = Console.ReadLine().ToUpper();
                }
            }
        }

        public static void Checkout(List<AddToCart> prdAddCarts)
        {
            Console.WriteLine("Checkout");
            foreach (AddToCart prd in prdAddCarts)
            {

                Console.WriteLine("$Proceed to checkout? Y/N");
                string myAns = Console.ReadLine().ToUpper();
                if (myAns == "Y")
                {
                    Console.WriteLine("Checkout successful!");
                    Console.WriteLine("Thank you for shopping with us!");
                    break;
                }
                else
                {
                    Console.WriteLine("Checkout canceled.");
                }
            }

        }
    }
}
