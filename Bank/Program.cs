using System;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = 0.0;

            Console.Write("Account number: ");
            int account = int.Parse(Console.ReadLine());

            Console.Write("Account holder name: ");
            string name = Console.ReadLine();

            Console.Write("Will there be an initial deposit (y/n)?: ");
            string option = Console.ReadLine();

            if (option.ToLower() == "y") {
                Console.Write("Enter the initial deposit amount: $");
                deposit = double.Parse(Console.ReadLine());
            } 

            Class1 class1 = new Class1(account, name, deposit);

            Console.Clear();
            Console.WriteLine("Account details:\r\n" + class1);

            Console.Write("Enter a deposit amount: ");
            deposit = double.Parse(Console.ReadLine());
            class1.AddDeposit(deposit);

            Console.Clear();
            Console.WriteLine("Updated account details:\r\n" + class1);

            
            Console.Write("Enter a withdrawal amount: ");
            deposit = double.Parse(Console.ReadLine());
            class1.Withdrawal(deposit);
            
            Console.Clear();
            Console.WriteLine("Updated account details:\r\n" + class1);

            Console.ReadKey();
        }
    }
}
