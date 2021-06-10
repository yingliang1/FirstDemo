using System;

namespace Exercise2
{
    public class Arithmetic
    {
        // add operation
        public void Add(int num1, int num2)
        {
            Console.WriteLine("Addition Of Two Numbers : " + (num1 + num2)); 
        }
        // subtract operation
        public void Subtract(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine("Subtraction Of Two Numbers : " + (num1 - num2));
            }
            else {
                Console.WriteLine("Subtraction Of Two Numbers : " + (num2 - num1));
            }
        }
        // multiply operation 
        public void Multiply(int num1, int num2)
        {
            Console.WriteLine("Multiplicaion Of Two Numbers : " + (num1 * num2)); 
        }

        // division operation
        public void Division(int num1, int num2)
        {
            Console.WriteLine("Division Of Two Numbers : " + (num1 / num2)); 
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic a1 = new Arithmetic();
            Console.Write("enter a: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("enter b: ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Divsion");
            Console.Write("choose operation: ");
            int c = Convert.ToInt16(Console.ReadLine());
            switch (c)
            {
                case 1:
                    a1.Add(a, b);
                    break;
                case 2:
                    a1.Subtract(a, b);
                    break;
                case 3:
                    a1.Multiply(a, b);
                    break;
                case 4:
                    a1.Division(a, b);
                    break;
                default:
                    Console.WriteLine("does not exist!");
                    break;
            }
          
        }
    }
}
