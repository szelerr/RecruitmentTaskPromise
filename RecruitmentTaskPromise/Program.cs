namespace RecruitmentTaskPromise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] options = [
                "1. Add product",
                "2. Remove product",
                "3. Buy product",
                "4. View basket",
                "5. Exit"
                ];

            List<Product> products = new List<Product>
            {
                new Product("Laptop", 2500),
                new Product("Keyboard", 120),
                new Product("Mouse", 90),
                new Product("Monitor", 1000),
                new Product("Debugging duck", 66)
            };

            List<Product> basket = new List<Product>();

            bool isRunning = true;
            int num;

            while (isRunning)
            {
                Console.WriteLine("Welcome to our Tech Store! What do you want to do?");

                foreach (string i in options)
                {
                    Console.WriteLine(i);
                }

                if (int.TryParse(Console.ReadLine(), out num) && num > 0 && num <= options.Length)
                {
                    Console.Clear();
                    switch (num)
                    {
                        case 1:
                            Console.Write("Create name of new product: ");
                            string input = Console.ReadLine();
                            Console.Write("Enter new price: ");
                            if (int.TryParse(Console.ReadLine(), out int price))
                            {
                                products.Add(new Product(input, price));
                                Console.WriteLine("Product successfully added");
                            }
                            else
                            {
                                Console.WriteLine("Price must be a number. Returning to main menu");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Pick id that you would like to remove");
                            for (int i = 0; i < products.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {products[i].Name}, ${products[i].Price}");
                            }

                            if (int.TryParse(Console.ReadLine(), out int idRemove) && idRemove > 0 && idRemove < products.Count)
                            {
                                products.Remove(products[idRemove - 1]);
                                Console.WriteLine("Product successfully removed");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect id. Returning to main menu");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Which product would you like to add to the basket?");
                            for (int i = 0; i < products.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {products[i].Name}, ${products[i].Price}");
                            }
                            if (int.TryParse(Console.ReadLine(), out int idBasket))
                            {
                                try
                                {
                                    basket.Add(products[idBasket - 1]);
                                    Console.WriteLine("Product successfully added to the basket");
                                }
                                catch (ArgumentOutOfRangeException ex)
                                {
                                    Console.WriteLine("Product id is not available. Returning to main menu");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid product id. Returning to main menu");
                            }
                            break;

                        case 4:
                            if (basket.Count == 0)
                            {
                                Console.WriteLine("Your basket is empty :(");
                            }

                            double total = basket.Sum(b => b.Price);

                            if (basket.Count == 2)
                            {
                                double cheapest = basket.OrderBy(b => b.Price).FirstOrDefault().Price;
                                total -= cheapest * 0.1;
                                Console.WriteLine("2 items in basket - 10% discount for the cheapest one!");
                            }

                            if (basket.Count >= 3)
                            {
                                double cheapest = basket.OrderBy(b => b.Price).FirstOrDefault().Price;
                                total -= cheapest * 0.2;
                                Console.WriteLine("Over 3 items in basket - 20% discount for the cheapest one!");
                            }

                            if (total > 5000)
                            {
                                total *= 0.95;
                                Console.WriteLine("Order amount over 5000 - 5% discount for the full order!");
                            }

                            for (int i = 0; i < basket.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {basket[i].Name}, default price ${basket[i].Price}");
                            }
                            Console.WriteLine($"Total: ${total}");
                            break;
                        case 5:
                            Console.WriteLine("Shutting down...");
                            return;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Unknown option. Try again");
                }
            }
        }
    }
}
