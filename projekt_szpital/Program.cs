using SzpitalLib.Core;
using SzpitalLib.Models;
using SzpitalApp.Handlers;

class Program
{
    static void Main(string[] args)
    {
        Szpital szpital = new Szpital();
        const string plik = "szpital.json";

        szpital.WczytajZPliku(plik);

        Console.WriteLine("Witaj w systemie administracyjnym szpitala!");
        Console.Write("Podaj nazwę użytkownika: ");
        string username = Console.ReadLine();

        Console.Write("Podaj hasło: ");
        string password = Console.ReadLine();

        var uzytkownik = szpital.Pracownicy.FirstOrDefault(p => p.NazwaUzytkownika == username && p.Haslo == password);

        if (uzytkownik == null)
        {
            Console.WriteLine("Nieprawidłowe dane logowania.");
            return;
        }

        if (uzytkownik is Administrator admin)
        {
            AdministratorHandler.ObslugaAdministratora(szpital, admin);
        }
        else if (uzytkownik is Lekarz lekarz)
        {
            LekarzHandler.WyświetlInformacjeLekarza(szpital, lekarz);
        }
        else if (uzytkownik is Pielegniarka pielegniarka)
        {
            PielegniarkaHandler.WyświetlInformacjePielegniarki(szpital, pielegniarka);
        }

        szpital.ZapiszDoPliku(plik);
    }
}
