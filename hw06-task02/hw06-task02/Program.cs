namespace hw06_task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primary number

            Console.Write("n: ");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            // `return;` means exit from the method, so we can use it to stop the program if the input is invalid
            if (n < 2) { Console.WriteLine("Not prime"); return; } // negative numbers, 0 and 1 are not prime
            if (n%2==0) { Console.WriteLine("Not prime"); return; } // even numbers greater than 2 are not prime
            if (n == 2) { Console.WriteLine("Prime"); return; } // the only even prime number


            // i * i <= n is equivalent to i <= sqrt(n)
            double limit = Math.Sqrt(n);
            for (int i = 3; i <= limit; i += 2) // check only odd numbers starting from 3
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Not prime");
                    return;
                }
            }

            Console.WriteLine("Prime");
        }
    }
}
