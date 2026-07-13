/**
Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number.
Test Data
Enter a number: 6
Enter the desired width: 6
Expected Output:

666666

66666

6666

666

66

6
 **/

Console.Write("Enter a symbol: ");
// char symbol = Console.ReadLine()[0]; // Is there a better way to do this? The newline character needs to be read in as well.


// could try this
char symbol = Console.ReadKey().KeyChar;
Console.WriteLine(); // Move to the next line after reading the symbol

Console.Write("Enter the desired width: ");
int width = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < width; i++)
{
    for (int j = 0; j < width - i; j++)
    {
        Console.Write(symbol);
    }
    Console.WriteLine();
}
