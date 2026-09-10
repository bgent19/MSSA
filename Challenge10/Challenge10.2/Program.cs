// LeetCode 88
int[] nums1 = [1, 2, 3, 0, 0, 0];
Merge(nums1, 3, [2, 5, 6], 3);
Console.WriteLine(string.Join(", ", nums1));

int[] nums2 = [1];
Merge(nums2, 1, [], 0);
Console.WriteLine(string.Join(", ", nums2));

int[] nums3 = [0];
Merge(nums3, 0, [1], 1);
Console.WriteLine(string.Join(", ", nums3));


void Merge(int[] nums1, int m, int[] nums2, int n)
{

    // two pointer.
    int i = m - 1, j = n - 1, k = m + n - 1;

    while (i >= 0 && j >= 0)
    {
        if (nums1[i] > nums2[j])
        {
            nums1[k--] = nums1[i--];
        }
        else
        {
            nums1[k--] = nums2[j--];
        }
    }

    while (j >= 0)
    {
        nums1[k--] = nums2[j--];
    }
}
