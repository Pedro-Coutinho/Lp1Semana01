using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inteiros
            sbyte mySByte = 1;
            byte myByte = 2;
            short myShort = 3;
            ushort myUShort = 4;
            int myInt = 5;
            uint myUInt = 6;
            long myLong = 7;
            ulong myULong = 8;
            
            Console.WriteLine(mySByte);
            Console.WriteLine(myByte);
            Console.WriteLine(myShort);
            Console.WriteLine(myUShort);
            Console.WriteLine(myInt);
            Console.WriteLine(myUInt);
            Console.WriteLine(myLong);
            Console.WriteLine(myULong);

            //Chars
            char unicode1 = '\u2706';
            char unicode2 = '\u2737';
            char unicode3 = '\u216A';
            char unicode4 = '\u2182';

            Console.WriteLine(unicode1);
            Console.WriteLine(unicode2);
            Console.WriteLine(unicode3);
            Console.WriteLine(unicode4);

            //Reais
            float myFloat = 0.1f;
            double myDouble = 0.2f;
            decimal myDecimal = 0.10f;

            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);
            Console.WriteLine(myDecimal);

            //Booleans
            bool myTrue = true;
            bool myFalse = false;

            Console.WriteLine(myTrue);
            Console.WriteLine(myFalse);

        }
    }
}
