using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDay6
{
    public class BinarySwap
    {
        public void swap(int s)
        {
            DecimalToBinary decimalToBinary = new DecimalToBinary();
            int [] N= decimalToBinary.Conversion(s);
            int[] a= new int[N.Length/2];
            int[] b = new int[N.Length / 2];
            for(int i=0;i<N.Length/2; i++)
            {
                a[i] = N[i];
            }
            int k = 0;
            for (int j = N.Length / 2; j < N.Length; j++)
            {
                b[k] = N[j];
                k++;
            }
            int[] swap = a.Concat(b).ToArray();
            double result = 0;
            double sum = 0;
            for(int d = swap.Length-1; d >=0;d--)
            { 
               result = swap[d]*Math.Pow(2,d);
                sum = sum + result;
            }
            Console.WriteLine(sum);


        }
    }
}
