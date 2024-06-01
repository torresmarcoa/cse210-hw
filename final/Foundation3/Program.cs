using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("PHP Basics", "Introduction to PHP", "06/06/2024", "10:00 AM", new Address("9919 Palm st", "Tuczon", "Arizona", "USA"), "Lecture", "Antony Smith", 200);
        OutdoorGathering outdoorGathering = new OutdoorGathering("Company Picnic", "Annual company picnic", "06/20/2024", "9:00 AM", new Address("0209 Oak Tree st", "Twin Falls", "Idaho", "USA"), "Outdoors", "Sunny");
        Reception reception = new Reception("Wedding Reception", "Celebrating the marriage of Jane and John", "07/05/2024", "5:00 PM", new Address("123 Grand st", "Salt Lake City", "Utha", "USA"), "Reception", "johndoe@hotmail.com");

        lecture.GetStandartDetails();
        lecture.GetFullDetails();
        lecture.GetShortDescription();

        outdoorGathering.GetStandartDetails();
        outdoorGathering.GetFullDetails();
        outdoorGathering.GetShortDescription();

        reception.GetStandartDetails();
        reception.GetFullDetails();
        reception.GetShortDescription();

    }
}