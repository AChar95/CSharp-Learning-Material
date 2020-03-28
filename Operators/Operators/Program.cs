using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            var c = 2;
            Console.WriteLine(a + b); // 13
            Console.WriteLine(a / b); // 3, as both 'a' and 'b' are both of type int, therefore the numbers after the decimal point do not exist (for this type)
            Console.WriteLine((float)a / (float)b); //This will return 3.3333333 as the value returned is a floating point number
            
            //In the following lines the program behaves similar to standard mathematics where C# will follow BOMDAS (Brackets Order Multiplication Division Addition and Subtraction)
            Console.WriteLine(a + b * c); // 16
            Console.WriteLine((a + b) * c); // 26

            //Comparison operators
            Console.WriteLine( a < b ); //false
            Console.WriteLine( a == b ); //false 
            Console.WriteLine( a != b ); //true      !(a != b) would give false, but this bad practice and difficult to follow
            Console.WriteLine( a > b && a > c); // true
            Console.WriteLine( a > b && b == c); // false -> as true AND false = false
            Console.WriteLine( a > b || b == c); // true -> as true OR false = true

        }
    }
}
