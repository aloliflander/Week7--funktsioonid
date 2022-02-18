using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene arv:");
            int usernumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv.");
            int usernumberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vali tehe (siseta '+', '*', '-' või '/')");
            char useroperator = Convert.ToChar(Console.ReadLine());

            switch (useroperator)
            {
                case '+':
                    AddTwoNumbers(usernumberOne, usernumberTwo );
                    break;
                case '/':
                    DivideTwoNumbers(usernumberOne, usernumberTwo);
                    break;
                case '*':
                    MultiplyTwoNumbers(usernumberOne, usernumberTwo);
                    break;
                case '-':
                    SubtractTwoNumbers(usernumberOne, usernumberTwo);
                    break;
                default:
                    Console.WriteLine("Kena päeva.");
                    break;
            }
        }
        private static void AddTwoNumbers(double x, double y)
        {
            double result = x + y;
            Console.WriteLine(result);
        }
        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }
        private static void MultiplyTwoNumbers(double x, double y)
        {
            double result = x * y;
            Console.WriteLine(result);
        }
        private static void SubtractTwoNumbers(double x, double y)
        {
            double result = x - y;
            Console.WriteLine(result);
        }


    }
}
