//Write a program in C# Sharp to find the sum of all array elements.

//Test Data :

//Input the number of elements to be stored in the array :3

//Input 3 elements in the array :

//element - 0 : 2

//element - 1 : 5

//element - 2 : 8

//Expected Output :

//Sum of all elements stored in the array is : 15

Console.Write("Input the number of elements to be stored in the array : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input {n} elements in the array :");

int[] nums = new int[n];
for (int i = 0; i < nums.Length; i++)
{
    Console.Write($"element - {i} : ");
    nums[i] = Convert.ToInt32(Console.ReadLine());
}

int sum = 0;
for (int i = 0; i < nums.Length; i++)
{
    sum += nums[i];
}
Console.WriteLine($"Sum of all elements stored in the array is : {sum}");