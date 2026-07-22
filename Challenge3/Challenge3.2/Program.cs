Console.Write("Enter text (terminated by ENTER): ");
string text = Console.ReadLine() ?? "";

int sum = 0;
foreach (var c in text.Where(c => char.IsDigit(c)))
{
    sum += c - '0'; // Has to be more efficient then cast to int
                    // same logic as "" vs string.Empty
                    // Trade clarity in intent for efficient operations
                    // ONLY works in ASCII!
}

Console.WriteLine($"The sum of the digits in that text was {sum}");