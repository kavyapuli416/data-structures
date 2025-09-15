using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program:Reverse
    {
        //  Write a program to take 5 numbers as input and print them.

        public void PrintNums()
        {
            int[] arr = new int[5];
            
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You entered:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }
        }

        //find the maxm number in array

        public void MaxNum()
        {
            int[] arr = { 3, 5, 2, 9, 6, 10, 8 };
            int max = arr[0];
            for(int i=0;i<arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max=arr[i];
                }
            }
            Console.WriteLine($"max num in array of hardcoded: {max}");
        }
        static void Main(string[] args)
        {
           // Program p = new Program();
            Reverse r = new Reverse();
           //p.PrintNums();
           // p.MaxNum();
            r.reverse();

            // 🔹 Keeps console open until user presses Enter
            Console.ReadLine();
        }
    }
}
