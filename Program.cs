using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 14.Определить, какие элементы массива А и сколько раз встречаются в массиве В. */

namespace Lab_4_1_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] B = { 5, 0, 3, 0, 3, 0, 7, 7, 0, 7, 7, 7 };

            for (int i = 0; i < A.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < B.Length; j++)                
                    if (A[i] == B[j])                    
                        count++;                
                if (count > 0)
                    Console.WriteLine($"A[i]={A[i]}, count={count}");
            }
            Console.ReadKey();
        }
    }
}
