namespace hw06_task03
{
    internal class Program
    {
        // a function that returns the length of the longest ascending sequence in an array of integers
        static public int LongestAscendingSequence(int[] numbers)
        {
            if(numbers.Length == 0) return 0;
            int currentLength = 1;
            int maxLength = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1] + 1) currentLength++;
                else currentLength = 1;
                maxLength = Math.Max(maxLength, currentLength);
            }
            return maxLength;
        }
        static void Main(string[] args)
        {
            Console.Write("Array size: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                return;
            }

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] = ");
                //arr[i] = int.Parse(Console.ReadLine());
                if (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Invalid input.");
                    return; //exit the program if input is invalid
                }
            }

            int result = LongestAscendingSequence(arr);
            Console.WriteLine($"Longest length = {result}");
        }
    }
}
