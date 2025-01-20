using System;
using System.Collections.Generic;

namespace SzpitalLib.Models
{
    public class Lekarz : Pracownik
    {
        public string Specjalnosc { get; set; }
        public string NumerPWZ { get; set; }
        public List<DateTime> Dyzurow { get; private set; } = new List<DateTime>();

        public Lekarz(string imie, string nazwisko, string pesel, string nazwaUzytkownika, string haslo, string specjalnosc, string numerPWZ)
            : base(imie, nazwisko, pesel, nazwaUzytkownika, haslo)
        {
            Specjalnosc = specjalnosc;
            NumerPWZ = numerPWZ;
        }

        public bool DodajDyżur(DateTime data)
        {
            if (Dyzurow.Count >= 10 || Dyzurow.Contains(data) || Dyzurow.Exists(d => (data - d).TotalDays == 1))
            {
                return false;
            }
            Dyzurow.Add(data);
            return true;
        }
    }
}
