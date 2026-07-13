//Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division. (May use a struct / class to represent the student)
//Test Data :
//Input the Roll Number of the student :784
//Input the Name of the Student :James
//Input the marks of Physics, Chemistry and Computer Application : 70 80 90
//Expected Output :
//Roll No : 784
//Name of Student : James
//Marks in Physics : 70
//Marks in Chemistry : 80
//Marks in Computer Application : 90
//Total Marks = 240
//Percentage = 80.00
//Division = First


Student student = new();

Console.Write("Input the Roll Number of the student :");
student.rollNo = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the Name of the Student :");
student.name = Console.ReadLine();

Console.Write("Input the marks of Physics, Chemistry and Computer Application :");
int[] marks = Console.ReadLine().Split().Select(int.Parse).ToArray();

foreach (var (i, mark) in marks.Index())
{
    student.classes[i].grade = mark;
}

Console.WriteLine("Roll No : " + student.rollNo);
Console.WriteLine("Name of Student : " + student.name);

foreach (var (i, name) in student.classes.Index())
{
    Console.WriteLine($"Marks in {student.classes[i].subject} : {student.classes[i].grade}");
}

int sum = 0;
double total = 0.0;
foreach (var mark in student.classes)
{
    sum += mark.grade;
    total += 100.0;
}

Console.WriteLine($"Total Marks = {sum}");

double percentage = (sum / total) * 100;

Console.WriteLine($"Percentage = {percentage:0.00}");

string div = "";
switch (percentage)
{
    case (> 79.99):
        div = "First";
        break;
    case (> 69.99):
        div = "Second";
        break;
    case (> 59.99):
        div = "Third";
        break;
    default:
        div = "Fail";
        break;
}

Console.WriteLine($"Division = {div}");






class Student
{
    public int rollNo;
    public string name;
    public Mark[] classes = new Mark[]
    {
        new Mark { subject = "Physics", grade = 0 },
        new Mark { subject = "Chemistry", grade = 0 },
        new Mark { subject = "Computer Application", grade = 0 }
    };
}

class Mark
{
    public string subject;
    public int grade;
}