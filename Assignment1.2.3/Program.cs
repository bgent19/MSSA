// Write a menu driven application to perform calculation functions like
// addition, subtraction, multiplication, and division. Call them appropriately
// when user selects the option. Give the user the option to continue or exit
// the program.

Console.WriteLine("Hello Calculator, I'm a calculator!");
Console.WriteLine();

while (true)
{
    switch(PrintMenuAndChoose())
    {
        case 1:
            Add();
            break;
        case 2:
            Subtract();
            break;
        case 3:
            Multiply();
            break;
        case 4:
            Divide();
            break;
        case 5:
            Console.WriteLine("Bye!");
            return;
        default:
            Console.WriteLine("Please select one of the menu options.");
            break;

    }
    Console.WriteLine();
}


int PrintMenuAndChoose()
{
    Console.WriteLine("Please select from one of the following options.");
    Console.WriteLine("Select the number item you would like then hit ENTER");
    Console.WriteLine("\t1. Addition");
    Console.WriteLine("\t2. Subtraction");
    Console.WriteLine("\t3. Multiplication");
    Console.WriteLine("\t4. Division");
    Console.WriteLine("\t5. Exit");
    Console.WriteLine();
    Console.Write("Choice: ");
    int response = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    return response;
}

void Add()
{
    Console.WriteLine("Addition");
    Console.WriteLine();
    double num1 = ReadNum();
    double num2 = ReadNum();
    Console.WriteLine();
    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
}

void Subtract()
{
    Console.WriteLine("Subtraction");
    Console.WriteLine();
    double num1 = ReadNum();
    double num2 = ReadNum();
    Console.WriteLine();
    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
}

void Multiply()
{
    Console.WriteLine("Multiplication");
    Console.WriteLine();
    double num1 = ReadNum();
    double num2 = ReadNum();
    Console.WriteLine();
    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
}

void Divide()
{
    Console.WriteLine("Division");
    Console.WriteLine();
    double num1 = ReadNum();
    double num2 = ReadNum();

    while(num2 == 0.0)
    {
        Console.WriteLine("0 cannot be the 2nd number in a division operation. Pick again.");
        num2 = ReadNum();
    }
    Console.WriteLine();
    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
}

double ReadNum()
{
    Console.Write("Enter a number: ");
    return Convert.ToDouble(Console.ReadLine());
}