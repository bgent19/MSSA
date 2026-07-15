//Write a C# Sharp program to find the largest of three numbers.

//Test Data :

//Input the 1st number :25

//Input the 2nd number :63

//Input the 3rd number :10

//Expected Output :

//The 2nd Number is the greatest among three

Console.WriteLine("Test Data :");

Console.Write("Input the 1st number : ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Input the 2nd number : ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Input the 3rd number : ");
int num3 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("The 1st Number is the greatest among three");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine("The 2nd Number is the greatest among three");
}
else if (num3 > num1 && num3 > num2)
{
    Console.WriteLine("The 3rd Number is the greatest among three");
}
else
{
    Console.WriteLine("There is no single greatest number.");
}

