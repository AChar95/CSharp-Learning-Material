using System;

namespace Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Below is a successful implicit conversion from byte to int as 
            byte b = 1;
            int i = b;
            //Trying to do int i = 1; byte b = i; the compiler will error out, this will require casting (explicit type conversion) instead. This is due to the chance of data loss
            Console.WriteLine(i);

            int iCast = 1;
            byte bCast = (byte)iCast;
            Console.WriteLine(bCast);

            string number = "1234";
            int intToString = Convert.ToInt32(number);
            Console.WriteLine(intToString);

            try
            {
                string numberError = "1234";
                byte bError = Convert.ToByte(numberError);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }

            try
            {
                string str = "true";
                bool bo = Convert.ToBoolean(str);
                Console.WriteLine(bo);
            }
            catch (Exception)
            {
                Console.WriteLine("The String could not be converted to a boolean type");
            }
        }
    }
}
