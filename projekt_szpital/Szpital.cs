using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using SzpitalLib.Models;

namespace SzpitalLib.Core
{
    public class Szpital
    {
        public List<Pracownik> Pracownicy { get; private set; } = new List<Pracownik>();

        public void DodajPracownika(Pracownik pracownik)
        {
            Pracownicy.Add(pracownik);
        }

        public void ZapiszDoPliku(string sciezka)
        {
            var options = new JsonSerializerOptions { WriteIndented = true, IncludeFields = true };
            var json = JsonSerializer.Serialize(Pracownicy, options);
            File.WriteAllText(sciezka, json);
        }

        public void WczytajZPliku(string sciezka)
        {
            if (File.Exists(sciezka))
            {
                var options = new JsonSerializerOptions { IncludeFields = true };
                var json = File.ReadAllText(sciezka);
                Pracownicy = JsonSerializer.Deserialize<List<Pracownik>>(json, options) ?? new List<Pracownik>();
            }
        }
    }
}
