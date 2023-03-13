using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDay6
{
    internal class SquareRoot
    {
        public void CalculateRoot(int R)
        {
            double t = R;
            double Epsilon = 1 * Math.Pow(10, -15);
            while(Math.Abs(t-(R/t))>Epsilon*t)
            {
                t= ((R/t)+t)/2;
            }
            Console.WriteLine("Square Root Of given Number is " + t);
        }
    }
}
