using System.Text.Json.Serialization;

namespace Students.Models;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    [JsonIgnore]
    public string FullName => $"{LastName} {FirstName}";
    [JsonIgnore]
    public int Age {
        get
        {
            var zeroTime = new DateTime(1, 1, 1);
            var span = DateTime.Now - DateOfBirth;
            return (zeroTime + span).Year - 1;
        }
    }
}