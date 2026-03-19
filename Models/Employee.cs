namespace apbd_cw2_s33684.Models;

public class Employee : User
{
    public Employee(int id, string name, string surname) : base(id, name, surname, 5)
    {
    }
}