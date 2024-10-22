namespace WestCoastEducationTS;

public class Utbildningsledare : Personuppgifter
{
    public int UtbildningsledareNummer { get; set; }
    public string? AnställningsDatum { get; set; }

    public Utbildningsledare(){}
    public Utbildningsledare(int utbildningsledareNummer)
    {
        UtbildningsledareNummer = utbildningsledareNummer;
        Find();
    }
    public override void Find()
    {
        if (UtbildningsledareNummer == 1)
        {
            InitializeUtbildningsledare("Jenny", "Holm", "0739785426", "19700708-2888", "Surgatan 29", "345 55", "Landskrona", "2023-07-15");
        }
        else if (UtbildningsledareNummer == 2)
        {
            InitializeUtbildningsledare("Helena", "Gunnarsson", "0769895822", "19600505-9822", "Tristgatan 26", "345 22", "Åstorp", "2024-01-17");
        }
        else
        {
            throw new ArgumentException($"Kunde inte hitta info: {UtbildningsledareNummer}");
        }
    }
    private void InitializeUtbildningsledare(string name, string lastName, string phone, string idNumber, string addressLine, string postalCode, string city, string anställningsDatum)
    {
        Namn = name;
        EfterNamn = lastName;
        TelefonNummer = phone;
        PersonNummer = idNumber;
        Adress.AdressLine = addressLine;
        Adress.PostNummer = postalCode;
        Adress.Ort = city;
        AnställningsDatum = anställningsDatum;
    }
    public override string DisplayInfo()
    {
        return $"{base.DisplayInfo()}, AnställningsDatum: {AnställningsDatum}";
    }
}