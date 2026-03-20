using apbd_cw2_s33684.Models;
using apbd_cw2_s33684.Services;

RentalService service = new RentalService();

Student s1 = new Student(21543, "Mark", "Evans");
Employee e1 = new Employee(102, "Thomas", "Newman");

Laptop l1 = new Laptop(1, "Silver HP Laptop", "i5", 16);
Projector p1 = new Projector(2, "Epson Projector", "High", "HDMI");
Camera c1 = new Camera(3, "Canon Camera", "FullFrame", true);

service.Users.Add(s1);
service.Users.Add(e1);
service.EquipmentList.Add(l1);
service.EquipmentList.Add(p1);
service.EquipmentList.Add(c1);

service.RentItem(s1, l1);
service.RentItem(s1, p1);
service.RentItem(s1, c1);

service.ReturnItem(l1, DateTime.Now.AddDays(10));

service.ShowReport();
