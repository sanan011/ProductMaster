using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_stack_tasks
{
    internal class products
    {
        public class Product
        {
            private ArrayList products;

            public Product()
            {
                products = new ArrayList();
            }

            public void Add(string category, string brand, string model, decimal price, int quantity)
            {
                products.Add(new ArrayList() { category, brand, model, price, quantity });
            }

            public ArrayList GetAllProducts()
            {
                return products;
            }

            public void ShowAllProducts()
            {
                int counter = 1;

                foreach (var product in products)
                {
                    Console.WriteLine($"PRODUCT {counter}:");

                    foreach (var item in (ArrayList)product)
                    {
                        Console.WriteLine(item);
                    }

                    counter++;
                }
            }

            public void ShowProductsByCategory(string category)
            {
                int counter = 1;
                foreach (ArrayList product in products)
                {
                    if (product[0].ToString().Equals(category, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"PRODUCT {counter}:");
                        foreach (var item in product)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    counter++;
                }
            }

            public void RemoveProduct(int index)
            {
                products.RemoveAt(index - 1);
            }

            public void UpdateProduct(int index, string category, string brand, string model, decimal price, int quantity)
            {
                products[index - 1] = new ArrayList() { category, brand, model, price, quantity };
            }

            public void UpdateProductByProperty(int productId, int propertyId, string newValue)
            {
                ArrayList product = (ArrayList)products[productId - 1];

                var oldValue = product[propertyId - 1];

                if (oldValue is string)
                {
                    product[propertyId - 1] = newValue;
                }
                else if (oldValue is decimal)
                {
                    product[propertyId - 1] = Convert.ToDecimal(newValue);
                }
                else if (oldValue is int)
                {
                    product[propertyId - 1] = Convert.ToInt32(newValue);
                }
            }

            public decimal GetTotalCompanyPrice()
            {
                decimal total = 0;
                foreach (ArrayList product in products)
                {
                    decimal price = (decimal)product[3];
                    int quantity = (int)product[4];
                    total += price * quantity;
                }
                return total;
            }

            public decimal GetTotalPriceForCategory(string category)
            {
                decimal total = 0;
                foreach (ArrayList product in products)
                {
                    if (product[0].ToString().Equals(category, StringComparison.OrdinalIgnoreCase))
                    {
                        decimal price = (decimal)product[3];
                        int quantity = (int)product[4];
                        total += price * quantity;
                    }
                }
                return total;
            }

            public void SellProduct(string model)
            {
                foreach (ArrayList product in products)
                {
                    if (product[2].ToString().Equals(model, StringComparison.OrdinalIgnoreCase))
                    {
                        int quantity = (int)product[4];
                        if (quantity > 0)
                        {
                            product[4] = quantity - 1;
                            Console.WriteLine($"Sold 1 unit of {product[1]} {product[2]}. Remaining quantity: {product[4]}");
                        }
                        else
                        {
                            Console.WriteLine("Product is out of stock.");
                        }
                        return;
                    }
                }
                Console.WriteLine("Product not found.");
            }
        }
    }
}
