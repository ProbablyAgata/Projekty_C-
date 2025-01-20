using System;
using System.Collections.Generic;

namespace SzpitalLib.Models
{
    public class Pielegniarka : Pracownik
    {
        public List<DateTime> Dyzurow { get; private set; } = new List<DateTime>();

        public Pielegniarka(string imie, string nazwisko, string pesel, string nazwaUzytkownika, string haslo)
            : base(imie, nazwisko, pesel, nazwaUzytkownika, haslo) { }
    }
}
