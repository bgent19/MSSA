
int[] nums = [2, 7, 11, 15];
int target = 9;

int[] result = SumToTarget(nums, target);

Console.WriteLine($"[{string.Join(',',result)}]");



int[] SumToTarget(int[] array, int target)
{
    int[] results = new int[2];
    Dictionary<int, int> remains = [];

    foreach(var (index, item) in array.Index())
    {
        if(remains.ContainsKey(target-item))
        {
            results[0] = remains[target - item];
            results[1] = index;
            break;
        }
        else
        {
            remains[item] = index;
        }
    }

    return results;
}