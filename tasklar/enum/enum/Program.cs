using System;
using System.Text;

namespace enummmm
{
    static class Program
    {
        static void Main(string[] args)
        {
            string s = "SIMare";
            s.Toname(); 
        }
        public static void Toname(this string str)
        {
            StringBuilder result = new StringBuilder();
            if (char.IsUpper(str[0]))
            {
                result.Append(char.ToUpper(str[0]));
            }


            for (int i = 1; i < str.Length; i++)
            {
                result.Append(char.ToLower(str[i]));
            }
            Console.WriteLine(result);
        }
        public static void Exmethod(string str, int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine(str);
            }
            else
            {

                Console.WriteLine($"{str}'s");
            }
        }

    
}
}
