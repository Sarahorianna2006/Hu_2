namespace MyNamespace.Models;

public class Tickets
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public double Price { get; set; }
    public DateTime Date { get; set; }
    public string? Place { get; set; }
    public bool Available { get; set; }
    
}