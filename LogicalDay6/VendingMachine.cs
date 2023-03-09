using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDay6
{
    public class VendingMachine
    {
       public void NotesReturned(int Amount)
        {
            int[] a = {1000,500,100,50,10,5,2,1};
            for(int i=0; i<a.Length; i++)
            {
                int R = Amount / a[i];
                if(R >= 1)
                {
                   Console.WriteLine(a[i] +"Note = " + R);
                    int C = a[i]*R;
                    Amount = Amount - C;
                }
                
            }

        }

    }
}
