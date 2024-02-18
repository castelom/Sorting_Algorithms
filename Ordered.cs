using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Castelom.Sorting_Algorithms
{
    internal class Ordered
    {
        private void Swap(int[] array,  int indexPrev, int indexNext)
        {
            int aux = array[indexPrev];
            array[indexPrev] = array[indexNext];
            array[indexNext] = aux;
        }

        public void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        //----------- Sorting Algorithms---------------//
        public void BubbleSort(int[] array)
        {
            for(int i = 0; i < array.Length-1; i++)
            {
                for (int j = 1;j < array.Length-1-i; j++)
                {
                    if (array[j-1] > array[j])
                    {
                        Swap(array, j - 1, j);
                    }
                }
            }
        }

        public void SelectionSort(int[] array)
        {
            int indexMin;
            for(int i = 0; i < array.Length - 1; i++)
            {
                indexMin = i;
                for(int j = i; j < array.Length-1; j++)
                {
                    if (array[indexMin] > array[j])
                        indexMin = j;
                }

                if(i != indexMin)
                {
                    Swap(array, i, indexMin);
                }
            }
        }

        public void InsertionSort(int[] array)
        {
            int aux;
            for(int i = 0;i < array.Length; i++)
            {
                int j = i;
                aux = array[i];
                while(j > 0 && array[j-1] > aux)
                {
                    array[j] = array[j-1];
                    j--;
                }
                array[j] = aux;
            }
        }
    }
}
