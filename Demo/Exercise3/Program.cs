using System;

namespace Exercise3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter a string to reverse:");
            string s1 = Console.ReadLine();
            int length = s1.Length - 1;
            string reverse = "";
            while (length >= 0)
            {
                reverse = reverse + s1[length];
                length--;
            }
            Console.WriteLine("reversed string is :" + reverse);
        }
    }
}
