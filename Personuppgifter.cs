namespace WestCoastEducationTS;

public class Personuppgifter: IPerson
{
    /* PROPERTIES */
    public string Namn { get; set; } = "";
    public string EfterNamn { get; set; } = "";
    public string TelefonNummer { get; set; } = "";
    public string PersonNummer { get; set; } = "";
    public Adress Adress { get; set; } = new Adress();

    public virtual void Find()
    {

    }
    public virtual string DisplayInfo()
    {
        return $"{Namn} {EfterNamn}, Telefonnummer: {TelefonNummer}, Personnummer: {PersonNummer}, Address: {Adress}";
    }
}
