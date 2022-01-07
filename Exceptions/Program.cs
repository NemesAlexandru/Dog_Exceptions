using System;
using MyExceptions;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Dog firstDog = new Dog(1, "Canye");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            

          //  ComputeSum(1, 101);

        }

        public static void ComputeSum(int a, int b) {

            // [a=2, b=100] sum only if params are between 2-100

            int sum = 0;

            if (a < 2 || a > 100)
            {
                throw new ArgumentOutOfRangeException();

            }

            if (b < 2 || b > 100)
            {
                throw new ArgumentOutOfRangeException();

            }

            sum = a + b;
        }
    }
}
