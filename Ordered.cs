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
        private void Swap(List<int> array,  int indexPrev, int indexNext)
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

        public void printArray(IList<int> array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        //----------- Sorting Algorithms---------------//
        //----------- Low Performance---------------//
        public void BubbleSort(List<int> array)
        {
            for(int i = 0; i < array.Count-1; i++)
            {
                for (int j = 1;j < array.Count - 1-i; j++)
                {
                    if (array[j-1] > array[j])
                    {
                        Swap(array, j - 1, j);
                    }
                }
            }
        }

        public void SelectionSort(List<int> array)
        {
            int indexMin;
            for(int i = 0; i < array.Count - 1; i++)
            {
                indexMin = i;
                for(int j = i; j < array.Count -1; j++)
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

        public void InsertionSort(List<int> array)
        {
            int aux;
            for(int i = 0;i < array.Count; i++)
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
        //----------- Low Performance---------------//


        //----------- High Performance---------------//

        private IList<int> Merge(IList<int> leftArray, IList<int> rightArray)
        {
            int i = 0, j = 0;
            IList<int> result = new List<int>();
            while(i < leftArray.Count && j < rightArray.Count) 
            {
                result.Add(leftArray[i] < rightArray[j]? leftArray[i++] : rightArray[j++]);
            
            }

            return result.Concat(i < leftArray.Count ? leftArray.Skip(i) : rightArray.Skip(j)).ToList();
        }

        public IList<int> MergeSort(IList<int> list)
        {
            if(list.Count > 1)
            {
                int middle = (int)Math.Floor((double)(list.Count / 2));
                IList<int> leftList = MergeSort(list.Take(middle).ToList());
                IList<int> rightList = MergeSort(list.Skip(middle).Take(list.Count-middle).ToList());
                list = Merge(leftList, rightList);

            }

            return list;
        }
    }
}
