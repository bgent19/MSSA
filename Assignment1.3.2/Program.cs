// Write a console application in C# to explore different ways in which array
// is declared and initialized and explore different properties and methods of
// Array class.

string[] cars;
cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
PrintStringArray(cars);

// Create an array of four elements, and add values later
int[] nums = new int[4];
for (int i = 0; i < nums.Length; i++)
    nums[i] = i;
PrintIntArray(nums);

// Create an array of four elements and add values right away 
string[] cars2 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
PrintStringArray(cars2);

// Create an array of four elements without specifying the size 
string[] cars3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
PrintStringArray(cars3);

// Create an array of four elements, omitting the new keyword, and without specifying the size
string[] cars4 = { "Volvo", "BMW", "Ford", "Mazda" };
PrintStringArray(cars4);


void PrintStringArray(string[] arr)
{
    foreach (string s in arr)
        Console.Write(s + " ");
    Console.WriteLine();
}


void PrintIntArray(int[] arr)
{
    foreach (int i in arr)
        Console.Write(i + " ");
    Console.WriteLine();
}