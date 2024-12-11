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
                            Console.WriteLine("\nCreate name of new product:");
                            string input = Console.ReadLine();
                            Console.WriteLine("Enter new price");
                            if (int.TryParse(Console.ReadLine(), out int price))
                            {
                                products.Add(new Product(input, price));
                                Console.WriteLine("Product successfully added.");
                            }
                            else
                            {
                                Console.WriteLine("Price must be a number. Try again");
                            }
                            break;
                        case 2:
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
