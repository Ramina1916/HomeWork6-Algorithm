namespace hw06_task10
{
    internal class Program
    {
        // a method that get an array of integers, return the triplets that their multiplication is the largest value
        static public int[] GetLargestTriplet(int[] arr) 
        {
            // make it more efficient -> O(n)
            if (arr.Length < 3)
            {
                throw new ArgumentException("Array must contain at least 3 elements.");
            }

            // Sort the array by loop to find the largest and smallest elements -> using complexity of Array.Sort() method is O(n log n) / loop sorting complexity is O(n)
            int largest1 = int.MinValue, largest2 = int.MinValue, largest3 = int.MinValue; // multiplication of three largest numbers = largest positive number
            int smallest1 = int.MaxValue, smallest2 = int.MaxValue; // (Negative × Negative = Positive) * one very large positive number = largest positive number

            foreach (int num in arr)
            {
                if (num > largest1)
                {
                    largest3 = largest2;
                    largest2 = largest1;
                    largest1 = num;
                }
                else if (num > largest2)
                {
                    largest2 = num;
                }
                else if (num > largest3)
                {
                    largest3 = num;
                }

                if (num < smallest1)
                {
                    smallest2 = smallest1;
                    smallest1 = num;
                }
                else if (num < smallest2)
                {
                    smallest2 = num;
                }
            }
            int product1 = largest1 * largest2 * largest3;
            int product2 = largest1 * smallest1 * smallest2;
            if (product1 > product2)
            {
                return new int[] { largest1, largest2, largest3 };
            }
            return new int[] { largest1, smallest1, smallest2 };

        }
        static void Main(string[] args)
        {

            int[] arr = { -10, -10, 5, 2, 8 };

            int[] result = GetLargestTriplet(arr);

            Console.WriteLine(
                $"[{result[0]}, {result[1]}, {result[2]}]");

            Console.WriteLine(
                $"Product = {result[0] * result[1] * result[2]}");

        }
    }
}
