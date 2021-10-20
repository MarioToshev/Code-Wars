using System;

namespace Persistent_Bugger_
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 39;
            long b = 999;
            long c = 3;
            Console.WriteLine(Persistence(a));
            Console.WriteLine(Persistence(b));
            Console.WriteLine(Persistence(c));
        }
        public static int Persistence(long n)
        {
            int count = 0;
            while (n.ToString().Length > 1)
            {
                char[] numbers = n.ToString().ToCharArray();
                n = 1;
                for (int i = 0; i < numbers.Length ; i++)
                {
                    n *= int.Parse(numbers[i].ToString());
                }
                    count++;
            }
            return count;
        }
    }
}
