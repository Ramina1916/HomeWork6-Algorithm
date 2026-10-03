namespace hw06_task01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Fibonacci Series with iteration -> O(n)

            Console.Write("n: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            if (n == 0)
            {
                Console.WriteLine("F(0) = 0");
            }
            else if (n == 1)
            {
                Console.WriteLine("F(1) = 1");
            }
            else
            {
                int first = 0;
                int second = 1;
                for (int i = 2; i <= n; i++)
                {
                    int next = first + second;
                    first = second;
                    second = next;
                }

                Console.WriteLine($"F({n}) = {second}");
            }
        }

    }
}
