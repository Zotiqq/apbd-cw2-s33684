namespace apbd_cw2_s33684.Models;

public class Equipment
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsAvailable { get; set; } = true;

    public Equipment(int id, string name)
    {
        Id = id;
        Name = name;
    }
}