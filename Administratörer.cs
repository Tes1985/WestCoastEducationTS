namespace WestCoastEducationTS;

public class Administratörer : Personuppgifter

{
    public int AdministratörNummer { get; set; }
    public string? KunskapsOmråde { get; set; }
    public string? Kurser { get; set; }
    public string? AnställningsDatum { get; set; }
    public Administratörer() { }
    public Administratörer(int administratörNummer)
    {
        AdministratörNummer = administratörNummer;
        Find();
    }
    public override void Find()
    {
        if (AdministratörNummer == 1)
        {
            InitializeUtbildningsledare("Annika", "Skog", "0739762541", "19700708-2888", "Grengången 2", "261 54", "Landskrona", "2022-01-24");
        }
        else
        {
            throw new ArgumentException($"Kunde inte hitta info: {AdministratörNummer}");
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
        return $"{base.DisplayInfo()}, Anställningsdatum: {AnställningsDatum}";
    }

}
