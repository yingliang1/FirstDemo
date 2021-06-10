using System;

namespace Exercise4
{
    public class ArmstrongNumber
    {
        public void method(int num1, int num2)
        {
            int temp, sum, r;
            for (int i = num1; i <= num2; i++)
            {
                temp = i;
                sum = 0;

                while (temp != 0)
                {
                    r = temp % 10;
                    temp = temp / 10;
                    sum = sum + (r * r * r);
                }
                if (sum == i)
                    Console.Write(i + "\n");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            ArmstrongNumber a = new ArmstrongNumber();
            a.method(num1, num2);
        }
    }
}
    
