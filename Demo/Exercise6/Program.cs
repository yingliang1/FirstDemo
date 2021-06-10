using System;

namespace Exercise6
{
    public class DiamondPrint
    {
        public void method(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                for (int j = 1; j <= num - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (int i = num - 1; i >= 1; i--)
            {
                for (int j = 1; j <= num - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the number of rows: ");
            int num = Convert.ToInt32(Console.ReadLine());

            DiamondPrint a = new DiamondPrint();
            a.method(num);
        }
    }
}
