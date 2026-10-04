namespace hw06_task08
{
    internal class Program
    {
        /* Is triangle:
        a + b > c
        a + c > b
        b + c > a
        a method that takes an array of numbers, check the triplets that can form a triangle 
        return true if it is possible to form a triangle, 
        otherwise return false.
        */
        static public bool IsTriangle(int[] array)
        {
           Array.Sort(array);
           for (int i = 0; i < array.Length - 2; i++) // length - 2 to avoid index out of range exception when accessing array[i + 2]
            {
               if (array[i] + array[i + 1] > array[i + 2])
               {
                   return true;
               }
           }
           return false;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 3, 4, 5, 6, 7, 9, 15, 20, 30 };
            Console.WriteLine(IsTriangle(numbers));
        }
    }
}
