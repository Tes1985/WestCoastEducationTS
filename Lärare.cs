using System.Security.Cryptography.X509Certificates;

namespace WestCoastEducationTS;

public class Lärare : Personuppgifter
{
    public string? Kurs { get; set; }
    public string? KunskapsOmråde { get; set; }
    public int Nummer { get; set; }

    public Lärare (int nummer)
    {
        Nummer = nummer;
        Find();
    }

    public override void Find()
    {
        if (Nummer == 1)
        {
            InitializeTeacher("Peter", "Klan", "0418-334455", "19890908-2234", "Snigelgatan 3", "454 77", "Stockholm", "Programmering 1", "Programmering");
        }
        else if (Nummer == 2)
        {
            InitializeTeacher("Sven", "Lundeberg", "040-123456", "20001222-0209", "Ljusvägen 23", "261 89", "Helsingborg", "Devops", "Systemutvecklare");
        }
        else if (Nummer == 3)
        {
            InitializeTeacher("Filip", "Nordström", "044-987654", "19680102-3313", "Isgatan 6", "343 78", "Kiruna", "Databas", "SystemUtvecklare");
        }
        else
        {
            throw new ArgumentException($"Kunde inte hitta lärare: {Nummer}");
        }
    }

    private void InitializeTeacher(string name, string lastName, string phone, string idNumber, string addressLine, string postalCode, string city, string kurs, string kunskapsOmråde)
    {
        Namn = name;
        EfterNamn = lastName;
        TelefonNummer = phone;
        PersonNummer = idNumber;
        Adress.AdressLine = addressLine;
        Adress.PostNummer = postalCode;
        Adress.Ort = city;
        Kurs = kurs;
        KunskapsOmråde = kunskapsOmråde;
    }
    public override string DisplayInfo()
    {
        return $"{base.DisplayInfo()}, Kurs: {Kurs}, Kunskapsområde: {KunskapsOmråde}";
    }
}

