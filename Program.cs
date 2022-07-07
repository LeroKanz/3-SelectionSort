using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 22, 44, 55, 7, 3, 12, 33 };
            SelectionSort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static void SelectionSort(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int currentIndex = 0; currentIndex < array.Length; currentIndex++)
            {
                int minIndex = currentIndex;

                for (int nextIndex = currentIndex + 1; nextIndex < array.Length; nextIndex++)
                {
                    if (array[nextIndex] < array[minIndex])
                    {
                        minIndex = nextIndex;
                    }
                }
                (array[minIndex], array[currentIndex]) = (array[currentIndex], array[minIndex]);
            }
        }
    }
}
