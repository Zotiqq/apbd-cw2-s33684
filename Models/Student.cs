namespace apbd_cw2_s33684.Models;

public class Student : User
{
    public Student(int id, string name, string surname) : base(id, name, surname, 2)
    {
    }
}