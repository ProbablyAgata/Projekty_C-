// Klasa Film 
public class Film
{
    public string Tytul { get; private set; }
    public string Rezyser { get; private set; }
    public bool Wypozyczenie { get; private set; }

    public Film(string tytul, string rezyser) 
    {
        Tytul = tytul;
        Rezyser = rezyser;
        Wypozyczenie = false;
    }

    public void Sprawdzanie()
    {
        if (!Wypozyczenie)
        {
            Wypozyczenie = true;
            Console.WriteLine($"{Tytul} został wypożyczony.");
        }
        else
        {
            Console.WriteLine($"{Tytul} jest już wypożyczony.");
        }
    }

    public void Zwrot()
    {
        if (Wypozyczenie)
        {
            Wypozyczenie = false;
            Console.WriteLine($"{Tytul} został zwrócony.");
        }
        else
        {
            Console.WriteLine($"{Tytul} nie był wypożyczony.");
        }
    }
}

// Klasa Klient
public class Klient
{
    public string Nazwa { get; private set; }
    private List<Film> wypozyczoneFilmy = new List<Film>(); 

    public Klient(string nazwa)
    {
        Nazwa = nazwa;
    }

    public void WypozyczFilm(Film film)
    {
        if (!film.Wypozyczenie)
        {
            film.Sprawdzanie();
            wypozyczoneFilmy.Add(film);
        }
        else
        {
            Console.WriteLine($"{film.Tytul} jest już wypożyczony.");
        }
    }

    public void ZwrotFilmow(Film film)
    {
        if (wypozyczoneFilmy.Remove(film))
        {
            film.Zwrot(); 
        }
        else
        {
            Console.WriteLine($"{Nazwa} nie wypożyczył {film.Tytul}.");
        }
    }
}

// Klasa WypozyczFilm
public class WypozyczFilm
{
    private List<Film> filmy = new List<Film>();  
    private List<Klient> klienci = new List<Klient>();  

    public void DodajFilm(Film film)
    {
        filmy.Add(film);
        Console.WriteLine($"{film.Tytul} został dodany do wypożyczalni.");
    }

    public void UtworzKlienta(Klient klient)  
    {
        klienci.Add(klient);
        Console.WriteLine($"{klient.Nazwa} został zarejestrowany.");
    }

    public void ListMovies()
    {
        Console.WriteLine("Filmy w wypożyczalni:");
        foreach (var film in filmy) 
        {
            Console.WriteLine($"{film.Tytul} by {film.Rezyser}");  
        }
    }
}

//Przykładowy program
class Program
{
    static void Main(string[] args)
    {
        WypozyczFilm pobranie = new WypozyczFilm();

        Film film1 = new Film("Oppenheimer", "Christopher Nolan");
        Film film2 = new Film("Barbie", "Greta Gerwig");

        pobranie.DodajFilm(film1);
        pobranie.DodajFilm(film2);

        Klient klient1 = new Klient("Alicja");
        Klient klient2 = new Klient("Tomek");

        pobranie.UtworzKlienta(klient1);
        pobranie.UtworzKlienta(klient2);

        pobranie.ListMovies();

        klient2.WypozyczFilm(film2);
        klient1.ZwrotFilmow(film1);
    }
}

