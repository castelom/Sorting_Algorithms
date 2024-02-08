// See https://aka.ms/new-console-template for more information
using Castelom.Sorting_Algorithms;

int[] array = { 5, 4, 3, 7, 8, 9, 10 };
Ordered order = new Ordered();
array = order.BubbleSort(array);

order.printArray(array);
