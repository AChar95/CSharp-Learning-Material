using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f; //remember that the C# compiler defaults to a double, a double cannot be converted to a float
            char character = 'A';
            string firstName = "AChar95";
            bool isWorking = true;

            var newVariable = 4; 
            /* 
             * Var can be used to replace the type of a variable, but this can pose some issues as for the example newVariable here is represented as a Int, 
             * this will occupy more memory than a byte, so for lean programs or when the maximum size of a variable is known then defining the variable, 
            */

            const float Pi = 3.14f;
            //These values cannot be modified

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

           /*
            * Below shows passing through a format string that features two placeholders, indicated by the {#} where the number in the {} indicates which arguement value it will take, 
            * if it is {0} then it will take the first value after the comma, this acts as a list, there can be many values after this comma, though it is important to remember that
            * the number in the brackets is one less than the position of that arguments
            */
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine( "{0} {1}", float.MinValue, float.MaxValue);


        }
    }
}
