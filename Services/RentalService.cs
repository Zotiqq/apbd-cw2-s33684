namespace apbd_cw2_s33684.Services;
using apbd_cw2_s33684.Models;

public class RentalService
{
    public List<User> Users = new List<User>();
    public List<Equipment> EquipmentList = new List<Equipment>();
    public List<Rental> Rentals = new List<Rental>();

    public void RentItem(User user, Equipment item)
    {
        int activeCount = 0;
        foreach (Rental r in Rentals)
        {
            if (r.User.Id == user.Id && r.DateReturned == null)
            {
                activeCount++;
            }
        }

        if (activeCount >= user.MaxRentals || !item.IsAvailable)
        {
            Console.WriteLine("Rental denied: Limit exceeded or item is currently unavailable.");
            return;
        }

        item.IsAvailable = false;
        Rentals.Add(new Rental(user, item, DateTime.Now.AddDays(7)));
        Console.WriteLine("Success: Rented " + item.Name + " to " + user.Surname);
    }

    public void ReturnItem(Equipment item, DateTime returnDate)
    {
        Rental foundRental = null;
        foreach (Rental r in Rentals)
        {
            if (r.Item.Id == item.Id && r.DateReturned == null)
            {
                foundRental = r;
                break;
            }
        }

        if (foundRental == null) return;

        foundRental.DateReturned = returnDate;
        item.IsAvailable = true;

        if (returnDate > foundRental.Deadline)
        {
            int daysLate = (returnDate - foundRental.Deadline).Days;
            foundRental.Penalty = daysLate * 10;
            Console.WriteLine("Overdue: " + daysLate + " days late. Penalty: " + foundRental.Penalty);
        }
        else
        {
            Console.WriteLine("Returned on time: " + item.Name);
        }
    }

    public void ShowReport()
    {
        Console.WriteLine("Total equipment: " + EquipmentList.Count);

        int availableCount = 0;
        foreach (Equipment e in EquipmentList)
        {
            if (e.IsAvailable) availableCount++;
        }
        Console.WriteLine("Available items: " + availableCount);

        int activeRentals = 0;
        foreach (Rental r in Rentals)
        {
            if (r.DateReturned == null) activeRentals++;
        }
        Console.WriteLine("Active rentals: " + activeRentals);
    }
}