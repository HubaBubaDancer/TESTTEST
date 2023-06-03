namespace TESTTEST.Models;

public class Category : BaseDbItem
{
    public string Name { get; set; } = null!;

    public List<Product>? Products { get; set; }
    

}