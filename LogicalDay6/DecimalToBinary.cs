using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDay6
{
    public class DecimalToBinary
    {
        public void Conversion(int B)
        {
            int[] arr = new int[50];
            int count = 0;
            for(int i=0;i<10 && B >=0;i++)
            {
                arr[i] = B % 2;
                B = B / 2;
                count++;
            }
            for(int j=count; j>=0; j--)
            {
                Console.Write(arr[j]);
            }

        }
    }
}
