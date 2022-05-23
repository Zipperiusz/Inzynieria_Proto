using System;
using System.Collections.Generic;

namespace PolTrain.Classes
{
    internal static class Init
    {
        public static List<Wagon> CreateWagon()
        {
            List<Wagon> wagony = new List<Wagon>();

            Wagon w1 = new Wagon(1, 20, 20, 0, "Pasażerski", 1);
            Wagon w2 = new Wagon(1, 20, 20, 0, "Pasażerski", 2);
            Wagon w3 = new Wagon(2, 20, 20, 0, "Pasażerski", 3);
            Wagon w4 = new Wagon(2, 20, 20, 0, "Pasażerski", 4);
            Wagon w5 = new Wagon(2, 20, 20, 0, "Pasażerski", 5);
            Wagon w6 = new Wagon(2, 20, 20, 0, "Pasażerski", 6);
            wagony.Add(w1);
            wagony.Add(w2);
            wagony.Add(w3);
            wagony.Add(w4);
            wagony.Add(w5);
            wagony.Add(w6);
            return wagony;
        }
        public static Pociag CreatePociag()
        {           
            return new Pociag("Szczeciniak", 6, 23323, CreateWagon());
        }
        public static List<Miejsce> CreateMiejsca(int ilosc)
        {
            List<Miejsce> miejsca=new List<Miejsce>();

            for (int j = 1; j <= ilosc; j++)
            {
                miejsca.Add(new Miejsce(j, false, false));
            }

            return miejsca;
        }
        public static 
    }
}
