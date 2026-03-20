Jest to system zarzadzajacy wypozyczaniem laptopow, projektorow i apartaow. 
System obsluguje studentow i pracownikow, pilnujac limitow i naliczajac kary za spoznienia.

Kod podzielilem na dwa glowne foldery: 
1. Models, gdzie trzymam klasy User i Equipment, 
uzylem takze dziedziczenia na tych klasach tworzac klasy Student, Employee, Laptop, Projector i Camera
2. Services tutaj znajduje sie klasa RentalService, ktora odpowiada za cala logike aplikacji,
sprawdza czy dana osobe moze wypozyczyc dana rzecz i liczy kary

Projekt zrealizowalem na dwoch osobnych galeziach roboczych. Po skonczeniu pracy na nich zmergowalem je z glowna galezia Master.
W pliku Program.cs przygotowalem krotki sceanriusz testowy, aby pokazac ze wszystko dziala poprawnie
