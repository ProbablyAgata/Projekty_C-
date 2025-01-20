namespace SzpitalLib.Models
{
    public class Administrator : Pracownik
    {
        public Administrator(string imie, string nazwisko, string pesel, string nazwaUzytkownika, string haslo)
            : base(imie, nazwisko, pesel, nazwaUzytkownika, haslo) { }
    }
}
