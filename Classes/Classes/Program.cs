using Classes.Math;
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

        }
    }
    //Please note that there is alternative to classes, these are structs.44
    //Struct are subtly different from classes, in most use cases classes are enough, structs are used for small lightweight objects that typically are not manipulated again, see below for an example

    public struct RgbColour
    {
        public int Red;
        public int Green;
        public int Blue;
    }

    // This could have been done with a class but if thousands of these are to be created then it is more efficient/effective to use a struct.
    // One of the main differences between a struct and class is that classes can inherit from other classes whereas structs cannot, not even from other structs.
    //They cannot be abstract or virtual unlike classes. They must be initialised before being used
}
