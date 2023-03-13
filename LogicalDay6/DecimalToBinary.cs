using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDay6
{
    public class DecimalToBinary
    {
        public int[] Conversion(int B)
        {
            int[] arr = new int[8];
            int count = 0;
            for(int i=0;i<8 && B >=0;i++)
            {
                arr[i] = B % 2;
                B = B / 2;
                count++;
            }
            return arr;

        }
    }
}
