using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Array_and_Strings
{
    //O(n^2)
    public class BubbleSort
    {
        public BubbleSort(int[] arr,int length)
        {
           var res= Sort(arr,length);
           foreach(var r in res)
            {
                Console.Write($"{r} ");
            }
        }
        public int[] Sort(int[] arr,int n)
        {
            bool flag = true;
            for(int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        flag = false;
                        Swap(arr,j, j+ 1);
                    }
                }
                if(flag)break;
            }
            return arr;
        }
        public void Swap(int[] arr,int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
