using System;

namespace type_conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversions
            byte a  = 5;
            sbyte b = 30;
            short c= 10;

            int d = a + b + c;
            Console.WriteLine("d:" + d);

            long h = d;
            
            //Explicit Conversions
        }
    }
}
