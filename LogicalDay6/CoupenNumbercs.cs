using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDay6
{
    public class CoupenNumbercs
    {
        public void CreateNumber(int Num)
        {
            int[] a = new int[Num];
            Random random = new Random();
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(1000, 5000);
                for(int j = 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        a[i] = random.Next(1000,5000);
                    }
                }
                Console.WriteLine("Coupen"+(i+1)+ ":" + a[i]);
            }
        }
    }
}
