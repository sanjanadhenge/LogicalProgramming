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
                Console.WriteLine("\nSelect an option \n1.Fibonacci Series \n2.Perfect Number\n3.Prime Number\n4.Reverse Number\n5.Day Of Week\n6.Temperature conversion\n7.Monthly Payment\n8.StopWatch\n9.Coupen Number\n10.Vending Machine\n11.Square Root\n12. Decimal To Binary\n13.Binary Swap\n14.Exit");
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
                        Console.WriteLine("Enter the Amount");
                        int A = Convert.ToInt32(Console.ReadLine());
                        VendingMachine vendingMachine = new VendingMachine();
                        vendingMachine.NotesReturned(A);
                        break;
                    case 11:
                        Console.WriteLine("Enter the Number");
                        int Root = Convert.ToInt32(Console.ReadLine());
                        SquareRoot squareRoot = new SquareRoot();
                        squareRoot.CalculateRoot(Root);
                        break;
                    case 12:
                        Console.WriteLine("Enter the Number");
                        int B = Convert.ToInt32(Console.ReadLine());
                        DecimalToBinary decimalToBinary = new DecimalToBinary();
                        decimalToBinary.Conversion(B);
                        break;
                    case 13:
                        Console.WriteLine("Enter the Number");
                        int Y = Convert.ToInt32(Console.ReadLine());
                        BinarySwap binarySwap = new BinarySwap();
                        binarySwap.swap(Y);
                        break;
                    case 14:
                        flag = false;
                        break;
                }
            }
        }
    }
}
