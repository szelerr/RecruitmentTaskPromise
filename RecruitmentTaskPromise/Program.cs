namespace RecruitmentTaskPromise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Welcome to our Tech Store! What do you want to do?");

                int num;

                if (int.TryParse(Console.ReadLine(), out num))
                {
                    switch (num)
                    {
                        case 1:
                            return;
                        case 2:
                            return;
                        case 3:
                            return;
                        case 4:
                            Console.WriteLine("Shutting down...");
                            isRunning = false;
                            return;
                    }
                }
            }
        }
    }
}
