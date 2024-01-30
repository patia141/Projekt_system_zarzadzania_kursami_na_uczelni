﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_system_zarzadzania_kursami_na_uczelni
{
    public class Nauczyciel
    {
        public int NauczycielId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public static List<Nauczyciel> nauczyciele = new List<Nauczyciel>();

        public void DodajNauczyciela(Nauczyciel nauczyciel)
        {
            nauczyciel.NauczycielId = nauczyciele.Count + 1;
            nauczyciele.Add(nauczyciel);
        }

        public Nauczyciel PobierzNauczyciela(int nauczycielId)
        {
            return nauczyciele.Find(n => n.NauczycielId == nauczycielId);
        }

        public void AktualizujNauczyciela(Nauczyciel updatedNauczyciel)
        {
            var existingNauczyciel = nauczyciele.Find(n => n.NauczycielId == updatedNauczyciel.NauczycielId);
            if (existingNauczyciel != null)
            {
                existingNauczyciel.Imie = updatedNauczyciel.Imie;
                existingNauczyciel.Nazwisko = updatedNauczyciel.Nazwisko;
            }
        }

        public void UsunNauczyciela(int nauczycielId)
        {
            nauczyciele.RemoveAll(n => n.NauczycielId == nauczycielId);
        }
    }
}