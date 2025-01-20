using SzpitalLib.Core;
using SzpitalLib.Models;

namespace SzpitalApp.Handlers
{
    public static class LekarzHandler
    {
        public static void WyświetlInformacjeLekarza(Szpital szpital, Lekarz lekarz)
        {
            Console.WriteLine($"Witaj, {lekarz.Imie} {lekarz.Nazwisko}!");
            foreach (var dyzur in lekarz.Dyzurow)
            {
                Console.WriteLine($"Dyżur: {dyzur:yyyy-MM-dd}");
            }
        }
    }
}
