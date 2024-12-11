namespace RecruitmentTaskPromise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] options = [
                "1. Add product",
                "2. Remove product",
                "3. Display Basket",
                "4. Exit"
                ];

            List<Product> products = new List<Product>
            {
                new Product("Laptop", 2500),
                new Product("Keyboard", 120),
                new Product("Mouse", 90),
                new Product("Monitor", 1000),
                new Product("Debugging duck", 66)
            };

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
                    switch (num)
                    {
                        case 1:
                            Console.Write("\nCreate name of new product: ");
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
                            for(int i=0; i<products.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {products[i].Name}");
                            }
                            if (int.TryParse(Console.ReadLine(), out int id) && id > 0 && id < products.Count)
                            {
                                products.Remove(products[id - 1]);
                                Console.WriteLine("Product successfully removed");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect id. Returning to main menu");
                            }
                            break;
                        case 3:
                            break;
                        case 4:
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
