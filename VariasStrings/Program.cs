using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string normalString1 = "This is a normal string with a new line \n";
            string verbatimString1 = @"This is a verbatim string with a new line \n";
            string normalString2 = "This is a normal string with a unicode \u2706";
            string verbatimString2 = @"This is a verbatim string with a unicode \u2706";

            Console.WriteLine(normalString1);
            Console.WriteLine(verbatimString1);
            Console.WriteLine(normalString2);
            Console.WriteLine(verbatimString2);
        }
    }
}
