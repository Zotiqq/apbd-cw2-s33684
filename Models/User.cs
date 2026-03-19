namespace apbd_cw2_s33684.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Role { get; set; }

    public User(int id, string name, string surname, string role)
    {
        Id = id; Name = name; Surname = surname; Role = role;
    }
}