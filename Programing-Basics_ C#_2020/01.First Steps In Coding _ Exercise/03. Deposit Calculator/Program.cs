using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int depocitMount = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double interest = deposit * percentage / 100;
            double interestForMount = interest / 12;

            double sum = deposit + (depocitMount * interestForMount);

            Console.WriteLine(sum);
        }
    }
}
