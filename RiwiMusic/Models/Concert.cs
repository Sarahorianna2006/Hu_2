namespace MyNamespace.Models;

public class Concert
{
    public int concertId { get; set; }
    public string? Title { get; set; }
    public string? Artist { get; set; }
    public string?Genre { get; set; }
    public string? City { get; set; }
   
    public DateTime date { get; set; } // año/mes/dia 
    
    
    
}