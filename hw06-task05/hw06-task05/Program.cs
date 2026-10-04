using Humanizer;
namespace hw06_task05
{
    internal class Program
    {
        // creating arrays outside of the method to avoid re-creating them every time the method is called
        static readonly string[] ones =
                { // each index corresponds to the number it represents -> index 8 = "eight"
                    "", "One", "Two", "Three", "Four",
                    "Five", "Six", "Seven", "Eight", "Nine"
                };
        static readonly string[] teens =
            { // each index corresponds to the number it represents -> index 13 = "thirteen"
                "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
                "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
            };

        static readonly string[] tens =
        { // each index corresponds to the number it represents -> index 2 = "twenty"
                "", "", "Twenty", "Thirty", "Forty",
                "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
        };

        // a method that converts a number to words
        public static string ConvertToWords(int number)
        {
            if (number == 0)
            {
                return "Zero";
            }
            if (number < 10)
            {
                return ones[number];
            }
            else if (number < 20)
            {
                return teens[number - 10];
            }
            else if (number < 100)
            {
                return tens[number / 10] + (number % 10 != 0 ? " " + ones[number % 10] : "");
            }
            else if (number < 1000)
            {
                return ones[number / 100] + " Hundred" + (number % 100 != 0 ? " and " + ConvertToWords(number % 100) : "");
            }
            else if (number < 10000)
            {
                return ones[number / 1000] + " Thousand" + (number % 1000 != 0 ? " " + ConvertToWords(number % 1000) : "");
            }
            return "";
        }
        static void Main(string[] args)
        {

            Console.Write("Number: ");
            if (!int.TryParse(Console.ReadLine(), out int number) || number < 0 || number > 9999)
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 9999.");
                return;
            }

            // using self-written method
            Console.WriteLine(ConvertToWords(number));

            // alternaive solution : using Humanizer library (ToWords() method)
            //Console.WriteLine(number.ToWords());
        }
    }
}
