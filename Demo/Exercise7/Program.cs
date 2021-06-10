using System;

namespace Exercise7
{
  
    class Program
    {
        static void Main(string[] args)
        {
            //ATMTransaction a = new ATMTransaction();
            Console.Write("Enter Your Pin Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int amount = 1000;
            int withdraw = 0;
            int deposit = 0;

            // menu initialize
            Console.WriteLine("********Welcome to ATM Service**************");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw Cash");
            Console.WriteLine("3. Deposit Cash");
            Console.WriteLine("4. Quit");
            Console.WriteLine("********************************************");
            while (true) {
                Console.Write("Enter your choice:");
                int c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Console.WriteLine("\n YOU’RE BALANCE IN Rs: {0} ", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n ENTER THE WITHDRAW MONEY: ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw > amount)
                        {
                            Console.WriteLine("\n sorry, the balance not enough");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n YOU’RE CURRENT BALANCE IS Rs : {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT: ");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("\n YOU’RE CURRENT BALANCE IS Rs : {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("\n THANK YOU");
                        break;

                }
            }
        }
    }
}
