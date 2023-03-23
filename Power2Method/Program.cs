using System;

namespace Power2Method
{

    /// <summary>
    /// This program as 2 methods apart from the Main method that calculate the powers of 2. The main method calls the other 2 methods to display those values. 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Calculates the power of 2 up to 5.
        /// </summary>
        
        private static void PowersOf2Until5()
        {
            for (int i = 1; i <= (1 << 5); i = i << 1)
            {
                PowerOf2UntilN(5);
                Console.WriteLine(i);
            }
        }
        

        /// <summary>
        /// Calculates the powers of 2 up to specified number
        /// </summary>
        /// <param name="n">The maximum power of 2 to calculate.</param>
        
        private static void PowerOf2UntilN(int n)
        {
            for (int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
        

        /// <summary>
        /// This method calculates the powers of two between the n1 and n2 values.
        /// </summary>
        /// <param name="n1">The first number that it will display the value of the power 2</param>
        /// <param name="n2">The last number that it will display the value of the power 2</param>
        private static void PowerOf2UntilN(int n1, int n2)
        {
            for (int i = n1; i <= (n1 << n2); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }

        

        /// <summary>
        /// The method PowersOf2Until5() is called 2 times to output the values of the power of 2 up to 5
        /// The method PowerOf2UntilN(int n)is also called to times to output the powers of 2 but on of them to 2 and the other to 3.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            PowerOf2UntilN(2);
            Console.WriteLine("------------------------");
            PowerOf2UntilN(3);
            Console.WriteLine("------------------------");
            PowersOf2Until5();
            Console.WriteLine("------------------------");
            PowersOf2Until5();
            Console.WriteLine("------------------------");
            PowerOf2UntilN(2,4);

        }
    }
}


