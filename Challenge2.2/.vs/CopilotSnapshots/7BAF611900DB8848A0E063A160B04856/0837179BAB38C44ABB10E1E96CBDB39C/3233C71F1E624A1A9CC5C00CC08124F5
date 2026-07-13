/**
Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.
**/

string secret = "password123"; // Example secret password

Console.Write("Enter User ID: ");
string? userID = Console.ReadLine();

int tries = 0;

while (tries < 3)
{
    Console.Write("Enter your password: ");
    string? password = ReadPasswordMasked();
    if(password.Equals(secret))
    {
        Console.WriteLine("Access granted!");
        break;
    }
    else
    {
        tries++;
        Console.WriteLine($"Incorrect password. You have {3 - tries} attempts left.");
    }
}

static string ReadPasswordMasked()
{
    string password = "";
    ConsoleKey key;

    do
    {
        var keyInfo = Console.ReadKey(intercept: true);
        key = keyInfo.Key;

        if (key == ConsoleKey.Backspace)
        {
            if (password.Length > 0)
            {
                password = password.Substring(0, password.Length - 1);
                Console.Write("\b \b");
            }
        }
        else if (key == ConsoleKey.Enter)
        {
            Console.WriteLine();
            break;
        }
        else if (!char.IsControl(keyInfo.KeyChar))
        {
            password += keyInfo.KeyChar;
            Console.Write("*");
        }
    } while (key != ConsoleKey.Enter);

    return password;
}
