// My user-defined class with 3 properties.
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public double Gpa { get; set; }

    public override string ToString()
    {
        return $"Id = {Id}, Name = {Name}, Gpa = {Gpa}";
    }
}
