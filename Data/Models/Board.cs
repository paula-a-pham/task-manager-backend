namespace Data.Models;

public class Board
{
    public byte Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public ICollection<Task>? Tasks { get; set; }
}
