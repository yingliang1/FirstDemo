using System;

namespace Exercise5
{
    public class BinaryTriangle
    {
        public void method(int num)
        {
            int lastInt = 0;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (lastInt == 1)
                    {
                        Console.Write("0");
                        lastInt = 0;
                    }
                    else if (lastInt == 0)
                    {
                        Console.Write("1");
                        lastInt = 1;
                    }
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the number of rows: ");
            int num = Convert.ToInt32(Console.ReadLine());

            BinaryTriangle a = new BinaryTriangle();
            a.method(num);
        }
    }
   
}
