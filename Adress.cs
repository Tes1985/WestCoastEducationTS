namespace WestCoastEducationTS;

public class Adress
{
public string AdressLine { get; set; } = "";
public string PostNummer { get; set; } = "";
public string Ort { get; set; } = "";

    public override string ToString()
    {
        return $"{AdressLine}, Postnummer: {PostNummer}, Ort: {Ort}";
    }
}
