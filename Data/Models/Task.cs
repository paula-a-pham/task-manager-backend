namespace Data.Models;

public class Task
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? LastUpdate { get; set;}
    public byte Priority { get; set; }
    public ICollection<string>? Tags { get; set; }
    public byte? BoardId { get; set; }
    public Board? Board { get; set; }
}
