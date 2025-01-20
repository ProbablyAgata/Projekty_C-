using SzpitalLib.Core;
using SzpitalLib.Models;

namespace SzpitalApp.Handlers
{
    public static class PielegniarkaHandler
    {
        public static void WyświetlInformacjePielegniarki(Szpital szpital, Pielegniarka pielegniarka)
        {
            Console.WriteLine($"Witaj, {pielegniarka.Imie} {pielegniarka.Nazwisko}!");
            foreach (var dyzur in pielegniarka.Dyzurow)
            {
                Console.WriteLine($"Dyżur: {dyzur:yyyy-MM-dd}");
            }
        }
    }
}
