// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using System.Reflection.Metadata.Ecma335;

//Console.WriteLine("Hello, World!");
//Plane Plane1 = new Plane();
//Plane1.Capacity = 200;
//Plane1.ManufactureDate = new DateTime(2013, 01, 31);
//Plane1.PlaneType = PlaneType.Boing;

//Plane Plane2 = new Plane(PlaneType.Boing, 100, new DateTime(2013, 01, 31));


Plane tayara3 = new Plane()
{
    Capacity = 25,
    ManufactureDate = new DateTime(2013, 01, 31),
    PlaneType = PlaneType.Boing
};

Passenger eliyet3ada = new Passenger
{
    FirstName = "salah",
    LastName = "3mor",
    EmailAdresse="TWT@esprit.tn"

};
Console.WriteLine(eliyet3ada.checkprofile("salah", "3mor","TWT@esprit.tn"));

Traveller Traveller1 = new Traveller
{
    FirstName = "test",
    LastName = "test1",
    Nationality = "amriki"


};
Console.WriteLine("***********");
Traveller1.PassengerType();

Staff staff1 = new Staff
{


    FirstName = "test2",
    LastName = "test2",
    Function = "3amel nadhafa"

};
Console.WriteLine("***********");
staff1.PassengerType();
