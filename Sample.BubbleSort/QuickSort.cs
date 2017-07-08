using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.BubbleSort
{
   public static class QuickSort
    {
        public static void Sort(int[] A, int lo, int hi)
        {
            if (lo < hi)
            {
                int p = LomutoPartition(A, lo, hi);
                Sort(A, lo, p - 1); 
                Sort(A, p + 1, hi); 
            }
        }
        private static int LomutoPartition(int[] A, int lo, int hi)
        {
            int P = A[hi];
          
            int i = lo-1;
            for (int j = lo; j<= hi - 1; j++)
            {
                if (A[j] <= P)
                {
                    i++;
                    Swap(A, i, j);
                }
            }
            Swap(A, i + 1, hi);
            return i + 1;
        }
        private static int HoarePartition(int[] A, int lo, int hi)
        {
            int P = A[lo];
            int i = lo ;
            int j = hi ;
           
            while (true)
           {
                while (A[i] < P)
                    i++;
                while (A[j] > P)
                    j--;

                if (i >= j)
                    return j;

                    Swap(A, i, j);
            }
           
        }
        private static void Swap( int[] A,int i,int j)
        {
            if (A[i] != A[j])
            {
                int temp = A[i];
                A[i] = A[j];
                A[j] = temp;
            }
        }
    }
}
