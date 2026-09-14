int[] nums1 = [2, 0, 2, 1, 1, 0];
Console.WriteLine(string.Join(", ", nums1));
SortColors(nums1);
Console.WriteLine(string.Join(", ", nums1));

int[] nums2 = [2, 0, 1];
Console.WriteLine(string.Join(", ", nums2));
SortColors(nums2);
Console.WriteLine(string.Join(", ", nums2));

void SortColors(int[] nums)
{
    int pointerZero = 0, pointerTwo = nums.Length - 1;
    int i = 0;

    while (i <= pointerTwo)
    {
        if (nums[i] == 0)
        {
            (nums[i], nums[pointerZero]) = (nums[pointerZero], nums[i]);
            if (i == pointerZero)
            {
                i++;
            }

            pointerZero++;

        }
        else if (nums[i] == 2)
        {
            (nums[i], nums[pointerTwo]) = (nums[pointerTwo], nums[i]);
            pointerTwo--;
        }
        else
        {
            i++;
        }
    }
}