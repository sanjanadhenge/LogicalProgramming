﻿using System;
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
                Console.WriteLine("Select an option 1.Fibonacci Series 2.Exit");
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
                        flag = false;
                        break;
                }
            }
        }
    }
}
