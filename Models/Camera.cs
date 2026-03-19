namespace apbd_cw2_s33684.Models;

public class Camera : Equipment
{
    public string SensorType { get; set; }
    public bool CanRecord4K { get; set; }

    public Camera(int id, string name, string sensorType, bool canRecord4K) : base(id, name)
    {
        SensorType = sensorType;
        CanRecord4K = canRecord4K;
    }
}