using System;

namespace ArgInt2Hex
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInt = false;
            int n;
            foreach(var arg in args)
            {
                isInt = int.TryParse(arg, out n);
                if(isInt){
                    Console.WriteLine($"Input int {n} in hex {n:x}");
                }
                else{
                    Console.WriteLine($"Input {arg} is not a int");
                }
            }
        }
    }
}
