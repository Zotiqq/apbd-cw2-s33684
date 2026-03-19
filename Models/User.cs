namespace apbd_cw2_s33684.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int MaxRentals { get; set; }

    public User(int id, string name, string surname, int maxRentals)
    {
        Id = id;
        Name = name;
        Surname = surname;
        MaxRentals = maxRentals;
    }
}