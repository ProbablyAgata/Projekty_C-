using SzpitalLib.Core;
using SzpitalLib.Models;

namespace SzpitalApp.Handlers
{
    public static class AdministratorHandler
    {
        public static void ObslugaAdministratora(Szpital szpital, Administrator admin)
        {
            Console.WriteLine("Zalogowano jako administrator.");
            Console.WriteLine("1. Wyświetl listę pracowników");
            Console.WriteLine("2. Dodaj nowego pracownika");

            string opcja = Console.ReadLine();
            switch (opcja)
            {
                case "1":
                    foreach (var pracownik in szpital.Pracownicy)
                    {
                        Console.WriteLine($"{pracownik.Imie} {pracownik.Nazwisko} - {pracownik.GetType().Name}");
                    }
                    break;
                case "2":
                    Console.WriteLine("Dodawanie nowego pracownika...");
                    // Logika dodawania użytkownika
                    break;
            }
        }
    }
}
