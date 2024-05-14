var arr = new List<int>() { 64, 34, 25, 5, 22, 11, 90, 12 };

Console.WriteLine($"Initial arr: {string.Join(", ", arr)}");
Console.WriteLine($"Selection Sorted arr: {string.Join(", ", SelectionSort(arr))}");

static List<int> SelectionSort(List<int> arr)
{
    int lowestValAtIndex;

    for (global::System.Int32 i = 0; i < arr.Count - 1; i++)
    {
        lowestValAtIndex = i;
        for (global::System.Int32 j = i + 1; j < arr.Count; j++)
        {
            if (arr[j] < arr[lowestValAtIndex])
            {
                lowestValAtIndex = j;
            }
        }

        if (lowestValAtIndex != i)
        {
            var lowestVal = arr[lowestValAtIndex];
            arr.RemoveAt(lowestValAtIndex);
            arr.Insert(i, lowestVal);
        }
    }

    return arr;
}
