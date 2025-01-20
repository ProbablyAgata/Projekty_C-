namespace SzpitalLib.Models
{
    public abstract class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; }
        public string NazwaUzytkownika { get; set; }
        public string Haslo { get; set; }

        protected Pracownik(string imie, string nazwisko, string pesel, string nazwaUzytkownika, string haslo)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            NazwaUzytkownika = nazwaUzytkownika;
            Haslo = haslo;
        }
    }
}
