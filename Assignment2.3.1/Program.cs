//Write a console application to create a text file and save your basic details like name, age, address ( use dummy data). Read the details from same file and print on console.

string[] details = { "Name: John Doe", "Age: 30", "Address: 123 Main St, Anytown, USA" };

using StreamWriter outFile = new("details.txt");
{
    foreach (string s in details)
    {
        outFile.WriteLine(s);
    }
}

outFile.Close();

try
{
    using StreamReader inFile = new("details.txt");
    {
        string text = inFile.ReadToEnd();

        Console.WriteLine(text);
    }

    inFile.Close();
}
catch (IOException e)
{
    Console.WriteLine($"An error occurred: {e.Message}");
}

