// See https://aka.ms/new-console-template for more information
using AdoNet.Models;
using AdoNet.Services;

Console.WriteLine("Hello, World!");
// Za ova treba da se stisne desen klik na dependencies i da se instalira Microsoft.Data.SQLClient

void PrintInColor(string text, ConsoleColor color = ConsoleColor.White)
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
}

void printStudents(List<Student> students)
{
    foreach (Student student in students)
    {
        Console.WriteLine(student);
    }
}

string connectionString = "Server=.\\SQLEXPRESS;Database=SEDC_DEMO_SHARP;Trusted_Connection=True;Integrated Security=True;Encrypt=False;";

StudentService studentService = new StudentService(connectionString);

PrintInColor("\n========== All Students ===========", ConsoleColor.Cyan);
var allStudents = studentService.GetAllStudents();
printStudents(allStudents);


PrintInColor("\n========== New Student ===========", ConsoleColor.Cyan);
string firstName = Console.ReadLine();

Student newStudent = new Student()
{
    FirstName = firstName,
    LastName = "Doe",
    DateOfBirth = new DateTime(2008,1,1),
    EnrolledDate = new DateTime(2025,5,26),
    Gender = 'M',
    NationalIdNumber = 123123,
    StudentCardNumber = "sc-85695"
};

studentService.InsertStudent(newStudent);