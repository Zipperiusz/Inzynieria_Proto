using System;
using System.Collections.Generic;

namespace PolTrain.Classes
{
    internal static class Init
    {
        public static List<Wagon> CreateWagon()
        {
            List<Wagon> wagony = new List<Wagon>()
            {
            new Wagon(1, 20, 13, "Pasażerski", 1),
            new Wagon(1, 20, 20, "Pasażerski", 2),
            new Wagon(2, 20, 20, "Pasażerski", 3),
            new Wagon(2, 20, 20, "Pasażerski", 4),
            new Wagon(2, 20, 20, "Pasażerski", 5),
            new Wagon(2, 20, 20, "Pasażerski", 6)
            };

           

            List<Miejsce> miejsca = new List<Miejsce>()
            {
                new Miejsce(1, false, false, wagony[0]),
                new Miejsce(2, false, true, wagony[0]),
                new Miejsce(3, false, true, wagony[0]),
                new Miejsce(4, false, true, wagony[0]),
                new Miejsce(5, false, false, wagony[0]),
                new Miejsce(6, false, false, wagony[0]),
                new Miejsce(7, false, false, wagony[0]),
                new Miejsce(8, false, false, wagony[0]),
                new Miejsce(9, false, true, wagony[0]),
                new Miejsce(10, false, false, wagony[0]),
                new Miejsce(11, false, false, wagony[0]),
                new Miejsce(12, false, true, wagony[0]),
                new Miejsce(13, false, false, wagony[0]),
                new Miejsce(14, false, true, wagony[0]),
                new Miejsce(15, false, false, wagony[0]),
                new Miejsce(16, false, false, wagony[0]),
                new Miejsce(17, true, true, wagony[0]),
                new Miejsce(18, true, false, wagony[0]),
                new Miejsce(19, true, false, wagony[0]),
                new Miejsce(20, true, false, wagony[0]),

            };

           
            wagony[0].Miejsca = miejsca;

            return wagony;
        }
        public static Pociag CreatePociag()
        {           
            return new Pociag("Szczeciniak", 6, 23323, CreateWagon());
        }

    }
}
