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

            bool isRunning = true;
            int num;

            while (isRunning)
            {
                Console.WriteLine("Welcome to our Tech Store! What do you want to do?");

                foreach (string i in options)
                {
                    Console.WriteLine(i);
                }

                bool isNum = int.TryParse(Console.ReadLine(), out num);

                if (isNum && num > 0 && num <= options.Length)
                {
                    switch (num)
                    {
                        case 1:
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
