using System;
using System.Collections;

namespace Full_stack_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            products.Product productManager = new products.Product();
            int choice;
            do
            {
                Console.WriteLine("1. Show all products");
                Console.WriteLine("2. Show products by category");
                Console.WriteLine("3. Show total company price");
                Console.WriteLine("4. Show total price for category");
                Console.WriteLine("5. Add product");
                Console.WriteLine("6. Sell product");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice, please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        productManager.ShowAllProducts();
                        break;
                    case 2:
                        Console.Write("Enter category (notebooks/phones): ");
                        string category = Console.ReadLine();
                        productManager.ShowProductsByCategory(category);
                        break;
                    case 3:
                        Console.WriteLine($"Total company price: ${productManager.GetTotalCompanyPrice()}");
                        break;
                    case 4:
                        Console.Write("Enter category (notebooks/phones): ");
                        category = Console.ReadLine();
                        Console.WriteLine($"Total price for {category}: ${productManager.GetTotalPriceForCategory(category)}");
                        break;
                    case 5:
                        Console.Write("Enter category (notebooks/phones): ");
                        category = Console.ReadLine();

                        Console.Write("Enter brand: ");
                        string brand = Console.ReadLine();

                        Console.Write("Enter model: ");
                        string model = Console.ReadLine();

                        decimal price;
                        while (true)
                        {
                            Console.Write("Enter price: ");
                            if (decimal.TryParse(Console.ReadLine(), out price) && price >= 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid price. Please enter a positive number.");
                            }
                        }

                        int quantity;
                        while (true)
                        {
                            Console.Write("Enter quantity: ");
                            if (int.TryParse(Console.ReadLine(), out quantity) && quantity >= 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid quantity. Please enter a non-negative integer.");
                            }
                        }

                        productManager.Add(category, brand, model, price, quantity);
                        Console.WriteLine("Product added successfully!");
                        break;
                    case 6:
                        Console.Write("Enter model to sell: ");
                        string modelToSell = Console.ReadLine();
                        productManager.SellProduct(modelToSell);
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            } while (choice != 0);
        }
    }
}
