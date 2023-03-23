using System;

namespace Power2Method
{
    class Program
    {
        private static void PowersOf2Until5()
        {
            for (int i = 1; i <= (1 << 5); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }

        private static void PowerOf2UntilN(int n)
        {
            for (int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {

            PowerOf2UntilN(2);
            Console.WriteLine("------------------------");
            PowerOf2UntilN(3);
            Console.WriteLine("------------------------");
            PowersOf2Until5();
            Console.WriteLine("------------------------");
            PowersOf2Until5();

        }
    }
}
