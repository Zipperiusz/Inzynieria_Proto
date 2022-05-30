using System;
using System.Collections.Generic;

namespace PolTrain.Classes
{
    internal static class Init
    {
        /// <summary>
        /// Zwraca listę zawierającą 20 obiektów klasy wagon.
        /// 
        /// </summary>
        public static List<Wagon> CreateWagon()
        {
            
            List<Miejsce> miejsca = new List<Miejsce>()
            {
                new Miejsce(1, false, false),
                new Miejsce(2, false, true),
                new Miejsce(3, false, true),
                new Miejsce(4, false, true),
                new Miejsce(5, false, false),
                new Miejsce(6, false, false),
                new Miejsce(7, false, false),
                new Miejsce(8, false, false),
                new Miejsce(9, false, true),
                new Miejsce(10, false, false),
                new Miejsce(11, false, false),
                new Miejsce(12, false, true),
                new Miejsce(13, false, false),
                new Miejsce(14, false, true),
                new Miejsce(15, false, false),
                new Miejsce(16, false, false),
                new Miejsce(17, true, true),
                new Miejsce(18, true, false),
                new Miejsce(19, true, false),
                new Miejsce(20, true, false),

            };

            //miejsca.Clear();
            //for(int i = 0; i < 20; i++)
            //    miejsca.Add(new Miejsce(i, false, false));
            

            List<Wagon> wagony = new List<Wagon>()
            {
                new Wagon(1, "Pasażerski", 1, miejsca),
                new Wagon(1, "Pasażerski", 2),
                new Wagon(2, "Pasażerski", 3),
                new Wagon(2, "Pasażerski", 4),
                new Wagon(2, "Pasażerski", 5),
                new Wagon(2, "Pasażerski", 6)
            };

            return wagony;
        }

        public static List<Wagon> CreateWagon2()
        {

            List<Miejsce> miejsca = new List<Miejsce>()
            {
                new Miejsce(1, false, false),
                new Miejsce(2, false, true),
                new Miejsce(3, false, true),
                new Miejsce(4, false, true),
                new Miejsce(5, false, false),
                new Miejsce(6, false, false),
                new Miejsce(7, false, false),
                new Miejsce(8, false, false),
                new Miejsce(9, false, true),
                new Miejsce(10, false, false),
                new Miejsce(11, false, false),
                new Miejsce(12, false, true),
                new Miejsce(13, false, false),
                new Miejsce(14, false, true),
                new Miejsce(15, false, false),
                new Miejsce(16, false, false),
                new Miejsce(17, true, true),
                new Miejsce(18, true, false),
                new Miejsce(19, true, false),
                new Miejsce(20, true, false),

            };

            //miejsca.Clear();
            //for(int i = 0; i < 20; i++)
            //    miejsca.Add(new Miejsce(i, false, false));


            List<Wagon> wagony = new List<Wagon>()
            {
                new Wagon(1, "Pasażerski", 1, miejsca),
                new Wagon(1, "Pasażerski", 2, miejsca)

            };

            return wagony;
        }

        public static Pociag CreatePociag()
        {           
            return new Pociag("Szczeciniak", 6, 23323, CreateWagon());
        }

        public static Pociag CreatePociag2()
        {
            return new Pociag("Pociagx", 2, 104284, CreateWagon2());
        }
    }
}
