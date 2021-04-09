using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Array_and_Strings
{
    public class QuickSort
    {
        int[] arr = null;
        public QuickSort(int[] arr)
        {
            this.arr = arr;
            Sort(0, arr.Length - 1);
            foreach(var r in arr)
            {
                Console.Write(r + " ");
            }
        }

        public void Sort(int l,int h)
        {
            int pivot = Partion(l, h);
            Sort(l, pivot - 1);
            Sort(pivot + 1, h);
        }
        public int  Partion(int l ,int h)
        {
            int pivot = arr[l];
            int i = l;
            int j = h;
            while (i < j)
            {
                while (arr[i] <= pivot) i++;
                while (arr[j] > pivot) j++;
                if (i < j)
                {
                    Swap(arr, i, j);
                }
            }
            Swap(arr, j, l);
            return j;
        }

        private void Swap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
