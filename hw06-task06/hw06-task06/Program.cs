namespace hw06_task06
{
    internal class Program
    {
        // a method that get an string and return the first non-repeating character in it
        static char FirstNonRepeatingCharacter(string str)
        {
            // create a dictionary as a frequency table 'char -> key' 'number of occurrences -> value'
            Dictionary<char, int> frequencyTable = new Dictionary<char, int>();

            // loop throught the tring to add value and key to the dictionary
            for(int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (frequencyTable.TryGetValue(c, out int count)) frequencyTable[c] = count + 1;
                else frequencyTable[c] = 1;
            }

            // check wether a value equal to 1, return that
            for(int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (frequencyTable[c] == 1) return c;
            }
            return '\0'; // return null character if no non-repeating character is found
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            char result = FirstNonRepeatingCharacter(input);

            if (result == '\0')
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine($"First non-repeating character: {result}");
            }
        }
    }
}
