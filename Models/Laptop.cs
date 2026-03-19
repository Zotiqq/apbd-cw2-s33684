namespace apbd_cw2_s33684.Models;

public class Laptop : Equipment
{
    public string Processor { get; set; }
    public int Ram { get; set; }

    public Laptop(int id, string name, string processor, int ram) : base(id, name)
    {
        Processor = processor;
        Ram = ram;
    }
}