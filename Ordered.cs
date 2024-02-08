using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castelom.Sorting_Algorithms
{
    internal class Ordered
    {
        public int[] BubbleSort(int[] array)
        {
            for(int i = 0; i < array.Length-1; i++)
            {
                for (int j = 1;j < array.Length-i; j++)
                {
                    if (array[j-1] > array[j])
                    {
                        int aux = array[j-1];
                        array[j-1] = array[j];
                        array[j] = aux;
                    }
                }
            }
            return array;
        }

        public void printArray(int[] array)
        {
            for(int i =0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
