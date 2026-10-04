namespace hw06_task04
{
    internal class Program
    {
        static public int[] TwoSum(int[] numbers, int target)
        {
            Dictionary<int, int> complement = new Dictionary<int, int>(); // key : number, value: index -> avoid duplicates
            for (int i = 0; i < numbers.Length; i++)
            {
                int needed = target - numbers[i];
                if (complement.TryGetValue(needed, out int index))
                {
                    return new int[] { index, i };
                }
                complement[numbers[i]] = i;
            }
            return Array.Empty<int>();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            if(!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
            {
                Console.WriteLine("Invalid input. Length must be non-negative integer!");
                return;
            }

            int[] numbers = new int[number];

            for(int i = 0; i < number; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    i--; // Decrement i to repeat this iteration
                }
            }

            Console.Write("Enter the target sum: ");
            if (!int.TryParse(Console.ReadLine(), out int target))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                return;
            }

            int[] result = TwoSum(numbers, target);
            if (result != null)
            {
                Console.WriteLine($"Indices of the two numbers that add up to {target}: [{result[0]}, {result[1]}]");
            }
            else
            {
                Console.WriteLine("No two numbers in the array add up to the target sum.");
            }
        }
    }
}
