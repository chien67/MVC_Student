// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

class A
{
    static void Main(string[] args)
    {
        IList<Student> students = new List<Student>()
        {
            new Student() {Id =1, StudentName="Chien", Age=23},
            new Student() {Id =2, StudentName="Binh", Age=16},
            new Student() {Id =3, StudentName="Manh", Age=40},
        };

        var student = from s in students
                      select new { StudentID = s.Id, Name = s.StudentName };
        foreach (var stud in student)
        {
            Console.WriteLine(stud.StudentID + "-" + stud.Name);
        }
    }
}
public class Student
{
    public int Id { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}