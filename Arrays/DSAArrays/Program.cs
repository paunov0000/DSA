var arr = new int[] { 83, 2, 1, -38, 5 };
Console.WriteLine($"Lowest value is: {FindLowestValue(arr)}");


static int FindLowestValue(int[] arr)
{
    //Time complexity: O(n)
    //Space complexity: O(1)
    var lowest = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < lowest)
        {
            lowest = arr[i];
        }
    }

    return lowest;
}