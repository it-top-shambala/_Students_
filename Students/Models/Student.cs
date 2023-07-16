namespace Students.Models;

public class Student : Person
{
    public string Faculty { get; set; }
    public bool IsActive { get; set; }
    public List<Mark> Marks { get; set; }
}