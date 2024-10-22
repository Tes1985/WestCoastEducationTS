namespace WestCoastEducationTS;

public class Studerande : Personuppgifter
{
     public int StudentNummer { get; private set; }

    public Studerande()
    {

    }
    public Studerande(int studentNummer)
    {
        StudentNummer = studentNummer;
        Find();
    }

    public override void Find()
    {
        if (StudentNummer == 1)
        {
            InitializeStudent("Tina", "Svan", "0739348889", "19700708-2888", "Gladgatan 22", "345 55", "Landskrona");
        }
        else if (StudentNummer == 2)
        {
            InitializeStudent("Siv", "Berg", "0769833078", "19600505-9822", "Lyckogatan 54", "345 22", "Åstorp");
        }
        else if (StudentNummer == 3)
        {
            InitializeStudent("Pia", "Lind", "0703889966", "19800101-1283", "Solgatan 78", "345 56", "Lund");
        }
        else
        {
            throw new ArgumentException($"Kunde inte hitta info: {StudentNummer}");
        }
    }

    private void InitializeStudent(string name, string lastName, string phone, string idNumber, string addressLine, string postalCode, string city)
    {
        Namn = name;
        EfterNamn = lastName;
        TelefonNummer = phone;
        PersonNummer = idNumber;
        Adress.AdressLine = addressLine;
        Adress.PostNummer = postalCode;
        Adress.Ort = city;
    }

    public override string DisplayInfo()
    {
        return $"{base.DisplayInfo()}";
    }

}


