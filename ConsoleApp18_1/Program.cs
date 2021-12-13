using System;

using System.Collections.Generic;

using System.IO;

namespace ConsoleApp3_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('[', ']');
            dict.Add('{', '}');
            dict.Add('(', ')');
            dict.Add('<', '>');
            dict.Add(']', ' ');
            dict.Add('}', ' ');
            dict.Add(')', ' ');
            dict.Add('>', ' ');

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch != '[' & ch != ']' & ch != '{' & ch != '}' & ch != '(' & ch != ')' & ch != '<' & ch != '>')
                {
                    str = str.Remove(i, 1);
                    i--;
                    continue;
                }

                if (stack.Count == 0 & str.Length > 0)
                {
                    stack.Push(dict[str[i]]);
                    continue;
                }             
                    if (str[i] == stack.Peek())
                    {
                        
                    stack.Pop();
                    }
                    else if (dict[ch] != str[i])
                    {
                        stack.Push(dict[ch]);
                    }
            }
            if (stack.Count > 0)
            {
                Console.WriteLine("Скобки расставлены неверно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены верно");
            }
            Console.WriteLine(stack.Count);
            Console.ReadLine();
            Run();
            Environment.Exit(0);
        }
    }
}



