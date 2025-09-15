using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Reverse
    {
        public void reverse()
        {
            //This does not modify the original array
            /*  int[] arr = { 2, 3, 4, 5, 6 };

              for(int i=arr.Length-1;i>=0;i--)
              {
                  Console.Write(arr[i]+" ");
              }*/

            //want to actually reverse the array in memory
            int[] arr = {2,3,4,5,6 };
            for(int i=0, j=arr.Length-1;i<j;i++,j--)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
