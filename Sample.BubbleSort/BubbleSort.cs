using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.BubbleSort
{
  public  class BubbleSort
    {
        public static void Sort(int[] array)
        {
            int l = array.Length;
            bool swap = true;
            int[] A = array;
            while (swap)
            {
                swap = false;
                for (int i = 1; i < l; i++)
                {
                    if (A[i - 1] > A[i])
                    {
                        Swap(A, i - 1, i);
                        swap=true;
                    }
                }
            }

        }

        private static void Swap(int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }

        public static int[] GetBigArray()
        {
            int j = 1000000 ;
            int[] array= new int[j];
            int i = j - 1;
            while (i < 10000)
            {
                array[i] = i;
                i++;
            }

            return array;
        }
    }
}
