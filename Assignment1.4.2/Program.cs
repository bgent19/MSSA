// Write a class: “Student” with private data members: StudentId ( int),
// StudentFname (string), StudentLname (string ), StudentGrade ( char ) and
// public properties for each data member. Instantiate the class and assign
// data to properties. Display the data back on console.



Student brett = new() {StudentId = 21, StudentFname = "Brett", StudentLname = "Gentile", StudentGrade = 'A'  };

Console.WriteLine(brett);


class Student
{
    private int studentId;
    private string studentFname = "";
    private string studentLname = "";
    private char studentGrade;

    public int StudentId
    {
        get { return studentId; }
        set { studentId = value; }
    }

    public string StudentFname
    {
        get { return studentFname; }
        set { studentFname = value; }
    }

    public string StudentLname
    {
        get { return studentLname; }
        set { studentLname = value; }
    }

    public char StudentGrade
    {
        get { return studentGrade; }
        set { studentGrade = value; }
    }

    public override string ToString()
    {
        return $"Student ID: {StudentId}, First Name: {StudentFname}, Last Name: {StudentLname}, Grade: {StudentGrade}";
    }
}