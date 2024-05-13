var arr = new int[] { 3, 27, 1, 18, 7, 22, 83 };
Console.WriteLine($"Initial array: {string.Join(", ", arr)}");
Console.WriteLine($"Sorted array: {string.Join(", ", BubbleSort(arr))}");

static int[] BubbleSort(int[] arr)
{
    //Time complexity: O(n^2)
    //Space complexity: O(1)
    for (int i = 0; i < arr.Length; i++)
    {
        var isSwapped = false;
        for (int j = 0; j < arr.Length - 1 - i; j++)
        {
            int tempVal;
            if (arr[j] > arr[j + 1])
            {
                tempVal = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = tempVal;
                isSwapped = true;
            }
        }
        if (isSwapped == false)
        {
            break;
        }
    }

    return arr;
}
