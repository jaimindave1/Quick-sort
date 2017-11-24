using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("How many elements:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter Element:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int low = 0;
            int high = arr.Length - 1;
            quickSort(arr, low, high); //left partition

            Console.WriteLine("Sorted array: [{0}]", string.Join(", ", arr));
            Console.ReadLine();
        }

        private static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int indexOfPivot = partition(arr, low, high);
                quickSort(arr, low, indexOfPivot - 1); //left partition
                quickSort(arr, indexOfPivot + 1, high); //right partition
            }
        }

        private static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);
            for (int index = low; index < high; index++)
            {
                if (arr[index] <= pivot)
                {
                    i++;
                    //swap arr[i] and arr[index]
                    int temp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = temp;
                }
            }

            //swap arr[i+1] and arr[pivot]
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;

            return i + 1;
        }
    }
}
