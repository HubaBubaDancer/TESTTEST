namespace TESTTEST.Models;

public class Product : BaseDbItem
{
    public string Name { get; set; } = null!;
    public string BriefName { get; set; } = null!;
    public string? Description { get; set; }
    public string? Characteristics { get; set; }
    public Category? Category { get; set; }

}