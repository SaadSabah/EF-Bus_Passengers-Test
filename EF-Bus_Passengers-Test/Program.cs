// See https://aka.ms/new-console-template for more information
using EF_Bus_Passengers_Test;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("One to many- many to one!");
MyDbContext Context = new MyDbContext();

//Passengers passenger1 = new Passengers();
//passenger1.FirstName = "Rami";
//passenger1.LastName = "Yasa";
//passenger1.BussId = 1;
//Context.Add(passenger1);
//Context.SaveChanges();

//Passengers passengers2 = Context.passengers.FirstOrDefault(x => x.Id.Equals(9));
//passengers2.FirstName = "Updated";
//passengers2.LastName = "Updated";
//Context.Update(passengers2);
//Context.SaveChanges();

//Passengers passengers3 = Context.passengers.FirstOrDefault(x => x.Id == 10);
//Context.passengers.Remove(passengers3);
//Context.SaveChanges();

Buss MyBuss = Context.busses.Include(x => x.PassengersList).SingleOrDefault(x => x.Id.Equals(2));
foreach (var buss in MyBuss.PassengersList)
{
    Console.WriteLine($"{buss.FirstName.PadRight(15)}{buss.LastName}");
}
    