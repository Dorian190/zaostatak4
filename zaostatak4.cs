using System;

class Search
{
    public int BinarySearch(int[] arr, int x)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == x)
                return mid;
            else if (arr[mid] < x)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Search searcher = new Search();
        int[] arr = GenerateArray(100);

        int index = searcher.BinarySearch(arr, 75);

        if (index != -1)
            Console.WriteLine($"Broj 75 je na indeksu: {index}");
        else
            Console.WriteLine("Broj 75 nije pronađen u nizu.");

        Console.ReadLine();
    }

    static int[] GenerateArray(int length)
    {
        int[] arr = new int[length];
        int count = 0;
        for (int i = 1; count < length; i += 2)
        {
            arr[count] = i;
            count++;
        }
        return arr;
    }
}




