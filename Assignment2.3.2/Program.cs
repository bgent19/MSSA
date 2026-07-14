//Design a tip calculator : enter the bill total, tip % and display grand total after adding tip.

//Use the format specifiers to display currency, % symbol.

Console.Write("Enter the bill total: ");
double bill = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the tip % (e.g 20): ");
double tip = Convert.ToDouble(Console.ReadLine()) / 100.0;

Console.WriteLine($"Bill Total: {bill:C}\nTip %: {tip:P0}\nGrand Total: {(bill + bill*tip):C}");