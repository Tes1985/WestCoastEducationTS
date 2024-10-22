using System.Text.Encodings.Web;
using System.Text.Json;

namespace WestCoastEducationTS;

class Program
{
    static void Main()
    {
        Admin admin = new Admin();
        Utbildningsledare utbildningsledare = new Utbildningsledare();


        admin.AddStudent(new Studerande(1));
        admin.AddStudent(new Studerande(2));
        admin.AddStudent(new Studerande(3));

        admin.AddLärare(new Lärare(1));
        admin.AddLärare(new Lärare(2));
        admin.AddLärare(new Lärare(3));

        admin.AddUtbildningsLedare(new Utbildningsledare(1));
        admin.AddUtbildningsLedare(new Utbildningsledare(2));

        admin.AddAdministratör(new Administratörer(1));

        try
        {
            admin.AddKurs(new Kurser(1, new Kursinfo(1), new Lärare(1)));
            admin.AddKurs(new Kurser(1, new Kursinfo(2), new Lärare(2)));
            admin.AddKurs(new Kurser(1, new Kursinfo(3), new Lärare(3)));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Fel: {ex.Message}");
        }

        // Visa kurs info...
        Console.WriteLine("Kurs info:");
        foreach (var kurs in admin.Kurser)
        {
            Console.WriteLine(kurs.ToString());
        }

        // Visa student info...
        Console.WriteLine("Info om studenter:");
        foreach (var student in admin.Studenter)
        {
            Console.WriteLine(student.DisplayInfo());
        }

        // Visa  info...
        Console.WriteLine("Info om lärare:");
        foreach (var lärare in admin.Lärare)
        {
            Console.WriteLine(lärare.DisplayInfo());
        }
        // Visa utbildningledare info...
        Console.WriteLine("Info om utbildningsledare:");
        foreach (var utbildningsLedare in admin.UtbildningsLedare)
        {
            Console.WriteLine(utbildningsLedare.DisplayInfo());
        }

        // Visa administratörer info...
        Console.WriteLine("Info om administratörer:");
        foreach (var administratörer in admin.Administratörer)
        {
            Console.WriteLine(administratörer.DisplayInfo());
        }

        // Spara Westcoast-Education som json...
        /* var options = new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            Encoder = JavaScriptEncoder.Un
        } */

        var path = string.Concat(Environment.CurrentDirectory, "/Data/kurser.json");
        
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented = true
        };
        var json = JsonSerializer.Serialize(admin.Kurser, options);
        File.WriteAllText(path, json);

        var allaKurser = File.ReadAllText(path);

        Console.WriteLine(allaKurser);
    }
}
