using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Simple_Pig_Latin
{
   public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PigIt("Hello World"));
        }

        public static string PigIt(string str)
        {
            return Regex.Replace(str, @"\w+", word => word.Value.MoveFirstToLast().AddAy());
        }
        public static string AddAy(this string word) 
        {
            return word + "ay"; 
        }
        public static string MoveFirstToLast(this string word)
        {
            return new string(word.Skip(1).Concat(word.Take(1)).ToArray());
        }


    }
}

