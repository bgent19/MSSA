// Mock data source: hard coded employee list.
// Filter target: salary > 5000 and age < 30.
List<Employee> employees = new List<Employee>
{
    new Employee { Id = 1, Name = "Ava Reyes",      Age = 24, Salary = 7200m },
    new Employee { Id = 2, Name = "Liam Foster",    Age = 31, Salary = 8100m },
    new Employee { Id = 3, Name = "Noah Patel",     Age = 27, Salary = 4500m },
    new Employee { Id = 4, Name = "Mia Chen",       Age = 29, Salary = 5001m },
    new Employee { Id = 5, Name = "Ethan Brooks",   Age = 22, Salary = 3900m },
    new Employee { Id = 6, Name = "Sofia Nunez",    Age = 26, Salary = 6400m },
    new Employee { Id = 7, Name = "Jonas Weber",    Age = 45, Salary = 12000m },
    new Employee { Id = 8, Name = "Priya Raman",    Age = 30, Salary = 9000m },
    new Employee { Id = 9, Name = "Kai Nakamura",   Age = 28, Salary = 5000m },
    new Employee { Id = 10, Name = "Elena Petrova", Age = 23, Salary = 10500m }
};

var employeeQuery = from employee in employees
                    where (employee.Salary > 5000 && employee.Age < 30)
                    select employee;

Console.WriteLine(string.Join(", ", employeeQuery));


class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public decimal Salary { get; set; }

    public override string ToString()
    {
        return $"{Name} ({Id})";
    }
}
