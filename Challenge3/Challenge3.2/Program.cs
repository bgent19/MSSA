Console.Write("Enter text (terminated by ENTER): ");
string text = Console.ReadLine();

int sum = 0;
foreach (var c in text.Where(c => Char.IsAsciiDigit(c)))
{
    sum += c - '0'; // Has to be more efficient then cast char to double to int
                    // same logic as "" vs string.Empty
                    // Trade clairty in intent for efficient operations
}

Console.WriteLine($"The sum of the digits in that text was {sum}");