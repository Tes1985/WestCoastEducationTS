namespace WestCoastEducationTS;

public class Admin : Personuppgifter
{
    public List<Kurser> Kurser { get; set; } = new List<Kurser>();
    public List<Studerande> Studenter { get; set; } = new List<Studerande>();
    public List<Utbildningsledare> UtbildningsLedare { get; set; } = new List<Utbildningsledare>();
    public List<Lärare> Lärare { get; set; } = new List<Lärare>();
    public List<Administratörer> Administratörer { get; set; } = new List<Administratörer>();

    public Admin()
    {

    }
    public void AddKurs(Kurser kurs)
    {
        Kurser.Add(kurs);
    }
    public void AddStudent(Studerande student)
    {
        Studenter.Add(student);
    }
    public void AddUtbildningsLedare(Utbildningsledare utbildningsLedare)
    {
        UtbildningsLedare.Add(utbildningsLedare);
    }
    public void AddLärare(Lärare lärare)
    {
        Lärare.Add(lärare);
    }
    public void AddAdministratör(Administratörer administratörer)
    {
        Administratörer.Add(administratörer);
    }
}

