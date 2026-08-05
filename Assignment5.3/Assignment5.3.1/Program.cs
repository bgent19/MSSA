Console.WriteLine(CanPlaceFlowers([1, 0, 0, 0, 1], 1)); // true
Console.WriteLine(CanPlaceFlowers([1, 0, 0, 0, 1], 2)); // false

static bool CanPlaceFlowers(int[] flowerbed, int n)
{

    int validSpaces = 0;
    if (flowerbed[0] == 0)
    {
        flowerbed[0] = 1;
        validSpaces++;
    }

    for (int i = 1; i < flowerbed.Length; i++)
    {
        if (flowerbed[i] == 0 && flowerbed[i - 1] == 0)
        {
            flowerbed[i] = 1;
            validSpaces++;
        }

        if (flowerbed[i] == 1 && flowerbed[i - 1] == 1)
        {
            flowerbed[i - 1] = 0;
            validSpaces--;
        }
    }

    return validSpaces >= n;
}