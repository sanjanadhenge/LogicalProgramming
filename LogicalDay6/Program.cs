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
                Console.WriteLine("Select an option 1.Fibonacci Series 2.Perfect Number 3.Prime Number 4.Reverse Number 5.Day Of Week 6.Temperature conversion 7.Monthly Payment 8.StopWatch 9.Coupen Number 10.Exit");
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
                        Console.WriteLine("Enter Day");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Month");
                        int m = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Year");
                        int y = Convert.ToInt32(Console.ReadLine());
                        DayOfWeek dayOfWeek = new DayOfWeek();
                        dayOfWeek.Get_Weekday(d, m, y);
                        break;
                    case 6:
                        Console.WriteLine("Select the Option 1. Celsius to Fahrenheit 2.Fahrenheit to  Celsius ");
                        int C = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Temperature");
                        int T = Convert.ToInt32(Console.ReadLine());
                        TempConversion tempConversion = new TempConversion();
                        tempConversion.Conversion(C,T);
                        break;
                    case 7:
                        Console.WriteLine("Enter Principle Amount");
                        double Amount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Year");
                        double Year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Rate");
                        double Rate = Convert.ToInt32(Console.ReadLine());
                        MonthlyPayment monthlyPayment = new MonthlyPayment();
                        monthlyPayment.CalculatePayment(Amount, Year, Rate);
                        break;
                    case 8:
                        StopWatch stopWatch = new StopWatch();
                        stopWatch.Run();
                        break;
                     case 9:
                        Console.WriteLine("Enter the Number of Coupen");
                        int Num = Convert.ToInt32(Console.ReadLine());
                        CoupenNumbercs coupen = new CoupenNumbercs();
                        coupen.CreateNumber(Num);
                        break;
                    case 10:
                        flag = false;
                        break;
                }
            }
        }
    }
}
