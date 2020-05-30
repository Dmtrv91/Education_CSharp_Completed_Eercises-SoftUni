using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava16Exercises8

//Мажорант на масив от N елемента е стойност, която се среща поне N/2+1 пъти.Напишете програма, която по даден масив от числа на-
//мира мажоранта на масива и го отпечатва.Ако мажорантът не съществува – отпечатва "The majorant does not exists!”.
//Пример: {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3

{
    class Program
    {
        static void findMajority(int[] arr, int n)
        {
            int maxCount = 0;
            int index = -1; 
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    index = i;
                }
            }
 
            if (maxCount > n / 2)
                Console.WriteLine(arr[index]);
            else
                Console.WriteLine("No Majority Element");
        }
 
        static public void Main()
        {
            int[] arr = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            int n = arr.Length;
 
            findMajority(arr, n);
        }
    }
}