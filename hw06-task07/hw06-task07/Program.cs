using System.Linq.Expressions;

namespace hw06_task07
{
    internal class Program
    {
        // a method to reverse a number, without converting to the string
        static public int Reverse(int number)
        {
            bool negative = number < 0;
            long temp = Math.Abs((long)number);
            long reversed = 0;

            while (temp > 0)
            {
                reversed = reversed * 10 + temp % 10;
                temp /= 10;
            }

            if (negative) reversed = -reversed;

            if (reversed > int.MaxValue || reversed < int.MinValue) return 0;

            return (int)reversed;
        }
        static void Main(string[] args)
        {

            Console.Write("Number: ");

            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            int result = Reverse(number);
            Console.WriteLine($"Reversed number: {result}");
        }
    }
}
