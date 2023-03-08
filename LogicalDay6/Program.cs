using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDay6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programming");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select an option 1.Fibonacci Series 2.Perfect Number 3.Prime Number 4.Reverse Number 5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the length of the series");
                        int n = Convert.ToInt32(Console.ReadLine());
                        FibonacciSeries series = new FibonacciSeries();
                        series.CreateSeries(n);
                        break;
                    case 2:
                        Console.WriteLine("Enter the Number");
                        int N = Convert.ToInt32(Console.ReadLine());
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.CheckPerfect(N);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Number");
                        int P = Convert.ToInt32(Console.ReadLine());
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.PrimeNumberCheck(P);
                        break;
                    case 4:
                        Console.WriteLine("Enter the Number");
                        int R = Convert.ToInt32(Console.ReadLine());
                        Reverse reverse = new Reverse();
                        reverse.ReverseNumber(R);
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
