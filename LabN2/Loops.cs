
static int[] Range(int start, int end)
{
    int length = end - start + 1;
    int[] a = new int[length];

    for (int x = 0; x < length; x++)
    {
        Console.WriteLine($"{start + x}");
        a[x] = start + x;
    }
    return a;
}

Range(15, 30);

static int[] RangeOdd(int start, int end)
{
    int array_start = (start % 2 != 0) ? start : start + 1;
    int length = ((end - array_start) / 2) + 1;
    int[] a = new int[length];

    for (int x = 0, y = array_start; y <= end; x++, y += 2)
    {
        Console.WriteLine($"a[x] = {y}");
        a[x] = y;
    }
    return a;
}

RangeOdd(15, 30);