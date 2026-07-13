Console.Write("Enter your name (followed by ENTER): ");
string name = Console.ReadLine();

Console.Write("How old are you,  " + name + "? ");
uint age = Convert.ToUInt32(Console.ReadLine());

Console.Write("Where do you live,  " + name + "? ");
string address = Console.ReadLine();

Console.WriteLine("Here is what I got:");
Console.WriteLine(name + " is " + age + " years old and lives at " + address);
Console.WriteLine("Great to meet you, " + name + "! Bye!");