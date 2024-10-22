namespace WestCoastEducationTS;

public class Kurser
{
    public Kursinfo Kursinfo { get; set; }
    public Lärare Lärare { get; set; }


    public Kurser(int amount, Kursinfo kursinfo, Lärare lärare)
    {
        Kursinfo = kursinfo;
        Lärare = lärare;
    }
    public override string ToString()
    {
        return $"Kurs: {Kursinfo.Titel}, Kursen börjar: {Kursinfo.Start}, Kursen slutar: {Kursinfo.Slut}, Kursens längd: {Kursinfo.LängdIVeckor}, Lärare: {Lärare.Namn}";
    }
}

