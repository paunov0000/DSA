var arr = new List<int>() { 64, 34, 25, 5, 22, 11, 90, 12 };
var arr2 = new int[] { 64, 34, 25, 5, 22, 11, 90, 12 };

Console.WriteLine($"Initial arr: {string.Join(", ", arr)}");
Console.WriteLine($"Selection Sorted arr: {string.Join(", ", SelectionSort(arr))}");
Console.WriteLine($"Improved Selection Sorted arr: {string.Join(", ", SelectionSortImproved(arr2))}");


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

static int[] SelectionSortImproved(int[] arr)
{
    int currLowestIndex;

    for (global::System.Int32 i = 0; i < arr.Length - 1; i++)
    {
        currLowestIndex = i;
        for (global::System.Int32 j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[currLowestIndex])
            {
                currLowestIndex = j;
            }
        }

        if (currLowestIndex != i)
        {
            var tempElementHolder = arr[i];
            arr[i] = arr[currLowestIndex];
            arr[currLowestIndex] = tempElementHolder;
        }
    }

    return arr;
}
