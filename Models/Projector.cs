namespace apbd_cw2_s33684.Models;

public class Projector : Equipment
{
    public string Resolution { get; set; }
    public string ConnectorType { get; set; }

    public Projector(int id, string name, string resolution, string connectorType) : base(id, name)
    {
        Resolution = resolution;
        ConnectorType = connectorType;
    }
}