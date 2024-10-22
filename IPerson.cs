namespace WestCoastEducationTS;

public interface IPerson
{
    /* PROPERTIES */
public string Namn {get; set;}
public string EfterNamn { get; set; }
public string TelefonNummer { get; set; }
public string PersonNummer { get; set; }
public Adress Adress { get; set; }

/* METHODS */
public void Find();

}
