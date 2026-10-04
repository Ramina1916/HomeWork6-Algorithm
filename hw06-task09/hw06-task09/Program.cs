namespace hw06_task09
{
    internal class Program
    {
        // A method that checks whether "[] () {}" are balanced or not
        static public bool IsBalaned(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach(char c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bracket String: ");
            string input = Console.ReadLine();
            bool isBalanced = IsBalaned(input);
            Console.WriteLine($"Is the string balanced? {isBalanced}");
        }
    }
}
