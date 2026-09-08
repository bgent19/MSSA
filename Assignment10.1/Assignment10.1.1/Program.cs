using System.Text.Json;
using System.Xml.Serialization;

// Assignment 10.1.1
// Serialize and deserialize a Student object in binary, XML, and JSON.

Student student = new()
{
    Id = 101,
    Name = "Brett G",
    Gpa = 3.95
};

Console.WriteLine("Original object:");
Console.WriteLine(student);
Console.WriteLine();

// ----- Binary -----
Console.WriteLine("=== Binary ===");

BinaryWriter writer = new(File.Create("student.bin"));
writer.Write(student.Id);
writer.Write(student.Name);
writer.Write(student.Gpa);
writer.Close();

BinaryReader reader = new(File.OpenRead("student.bin"));
Student binaryStudent = new()
{
    Id = reader.ReadInt32(),
    Name = reader.ReadString(),
    Gpa = reader.ReadDouble()
};
reader.Close();

Console.WriteLine("Deserialized: " + binaryStudent);
Console.WriteLine();

// ----- XML -----
Console.WriteLine("=== XML ===");

XmlSerializer serializer = new(typeof(Student));

FileStream xmlWriteStream = File.Create("student.xml");
serializer.Serialize(xmlWriteStream, student);
xmlWriteStream.Close();

FileStream xmlReadStream = File.OpenRead("student.xml");
Student xmlStudent = (Student)serializer.Deserialize(xmlReadStream)!;
xmlReadStream.Close();

Console.WriteLine(File.ReadAllText("student.xml"));
Console.WriteLine("Deserialized: " + xmlStudent);
Console.WriteLine();

// ----- JSON -----
Console.WriteLine("=== JSON ===");

string json = JsonSerializer.Serialize(student);
File.WriteAllText("student.json", json);

Student jsonStudent = JsonSerializer.Deserialize<Student>(json)!;

Console.WriteLine(json);
Console.WriteLine("Deserialized: " + jsonStudent);
