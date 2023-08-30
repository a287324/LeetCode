// See https://aka.ms/new-console-template for more information


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            Solution solution = new Solution();
            // string s = "()";
            string s = "()[]{}";
            // string s = "(]";
            // string s = "(";
            if (solution.IsValid(s))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }

    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (stack.Count == 0)
                {
                    return false;
                }
                else
                {
                    char top = stack.Pop();
                    switch (c)
                    {
                        case ')':
                            if (top != '(') return false;
                            break;
                        case '}':
                            if (top != '{') return false;
                            break;
                        case ']':
                            if (top != '[') return false;
                            break;
                        default:
                            throw new Exception("Weird");
                    }
                    //if ((c == ')' && top != '(') ||
                    //    (c == '}' && top != '{') ||
                    //    (c == ']' && top != '['))
                    //{
                    //    return false;
                    //}
                }
            }
            return stack.Count == 0;
        }
    }
}




