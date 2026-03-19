namespace apbd_cw2_s33684.Models;

public class Rental
{
    public User User { get; set; }
    public Equipment Item { get; set; }
    public DateTime DateRented { get; set; }
    public DateTime Deadline { get; set; }
    public DateTime? DateReturned { get; set; }
    public decimal Penalty { get; set; }

    public Rental(User user, Equipment item, DateTime deadline)
    {
        User = user;
        Item = item;
        DateRented = DateTime.Now;
        Deadline = deadline;
        Penalty = 0;
    }
}