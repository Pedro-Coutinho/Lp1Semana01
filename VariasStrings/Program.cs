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

            //Concatenação
            int x = 1;
            string conc1 = "abc" + x;
            string conc2 = "abc" + 1;

            //Interpolação
            x = 7;
            int y = 2;
            string inter1 = $"Valor de x = {x}";
            string inter2 = $"y = {y}, então y + x = {y+x}";

            Console.WriteLine(inter1);
            Console.WriteLine(inter2);

            //String Formarting
            string strF = String.Format("Y é {0}, X é {1}", y, x);
            Console.WriteLine(strF);

            //Direto
            Console.WriteLine("This is a normal String with \"");
            Console.WriteLine(@"This is a verbatim String with \""");
            Console.WriteLine("This is a concatenated string + " + x);
            Console.WriteLine($"This is a interpolated String, x = {x}");
            Console.WriteLine(String.Format("This is a formated string, x = {0}, y = {1}",x,y));
        }
    }
}
