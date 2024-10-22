namespace WestCoastEducationTS;

public class Kursinfo
{
    public int KursNummer { get; set; }
    public string? Titel { get; set; }
    public int LängdIVeckor { get; set; }
    public string? KursTyp { get; set; }
    public string? Start { get; set; }
    public string? Slut { get; set; }

    public Kursinfo(int kursnummer)
    {
        KursNummer = kursnummer;
        FindCourses();
    }
    private void FindCourses()
    {
        if (KursNummer == 1)
        {
            Titel = "Programmering 1";
            LängdIVeckor = 4;
            KursTyp = "Distans";
            Start = "2025-01-06";
            Slut = "2025-01-31";
        }
        else if (KursNummer == 2)
        {
            Titel = "Devops";
            LängdIVeckor = 4;
            KursTyp = "PlatsBunden";
            Start = "2025-01-06";
            Slut = "2025-01-31";
        }
        else if (KursNummer == 3)
        {
            Titel = "Databas";
            LängdIVeckor = 4;
            KursTyp = "Distans";
            Start = "2025-01-06";
            Slut = "2025-01-31";
        }
        else
        {
            throw new ArgumentException($"Error: {KursNummer}");
        }

    }
    public string DisplayCourseInfo()
    {
        return $"Kursnummer: {KursNummer}, Kursnamn: {Titel}, KursLängd: {LängdIVeckor}, KursTyp: {KursTyp} Stratdatum: {Start}/ Slutdatum: {Slut}.";
    }
}
