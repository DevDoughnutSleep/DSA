using System;

class Program
{
    static void Main()
    {
        // Step 1: Ask user for array length
        Console.Write("Enter the length of the array: ");
        int arrayLength = int.Parse(Console.ReadLine());

        // Step 2: Generate random array
        Random random = new Random();
        int[] array = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = random.Next(0, 101);
        }
        Console.WriteLine("Generated array: " + string.Join(", ", array));

        // Step 3: Sort the array using selection sort
        void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIdx])
                    {
                        minIdx = j;
                    }
                }
                int temp = arr[minIdx];
                arr[minIdx] = arr[i];
                arr[i] = temp;
            }
        }

        SelectionSort(array);
        Console.WriteLine("Sorted array: " + string.Join(", ", array));

        // Step 4: Ask user for the item to find
        Console.Write("Enter the item to find in the array: ");
        int itemToFind = int.Parse(Console.ReadLine());

        // Step 5: Find the index using binary search
        int BinarySearch(int[] arr, int x)
        {
            int low = 0, high = arr.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == x)
                    return mid;
                if (arr[mid] < x)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }

        int index = BinarySearch(array, itemToFind);
        if (index != -1)
        {
            Console.WriteLine($"Item {itemToFind} is at index {index}");
        }
        else
        {
            Console.WriteLine($"Item {itemToFind} is not in the array");
        }
    }
}
