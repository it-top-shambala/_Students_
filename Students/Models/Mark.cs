namespace Students.Models;

public class Mark
{
    public DateTime Data { get; set; }
    public string Subject { get; set; }
    public Teacher Teacher { get; set; }
    public int Rating { get; set; }
}