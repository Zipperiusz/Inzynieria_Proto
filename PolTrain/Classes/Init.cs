using System;
using System.Collections.Generic;

namespace PolTrain.Classes
{
    internal static class Init
    {
        /// <summary>
        /// Zwraca listę zawierającą 6 obiektów klasy wagon.
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

            

            List<Wagon> wagony = new List<Wagon>()
            {
                new Wagon(1, "Pasażerski", 1, miejsca),
                new Wagon(1, "Pasażerski", 2,miejsca),
                new Wagon(2, "Pasażerski", 3,miejsca),
                new Wagon(2, "Pasażerski", 4,miejsca),
                new Wagon(2, "Pasażerski", 5,miejsca),
                new Wagon(2, "Pasażerski", 6,miejsca)
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

            

            List<Wagon> wagony = new List<Wagon>()
            {
                new Wagon(1, "Pasażerski", 1, miejsca),
                new Wagon(1, "Pasażerski", 2, miejsca)

            };

            return wagony;
        }

        public static Pociag CreatePociag()
        {           
            return new Pociag("Szczeciniak", 6, 23323, CreateWagon(), CreateTrasy());
        }

        public static Pociag CreatePociag2()
        {
            return new Pociag("Pociagx", 2, 104284, CreateWagon2(), CreateTrasy());
        }

        public static Klient CreateKlient()
        {
            return new Klient("JanKowalski","jan.kowalski@gmail.com","1234",1, "Jan", "Kowalski");
        }

        public static List<Trasa> CreateTrasy()
        {
            //Stacja _stacjaPocz, Stacja _stacjaKon, float _dlugosc,
            //int _iloscKupionychBiletow, int _numerTrasy, Pociag _pociag
            List<Trasa> miejsca = new List<Trasa>()
            {
                new Trasa(
                    new Stacja("Stacja1", new DateTime(2022,06,24,12,30,0), new DateTime(2022,06,24,12,35,30), 41),
                    new Stacja("Stacja2", new DateTime(2022,06,24,15,45,30), new DateTime(2022,06,24,15,50,0), 50),
                    250, 55, 30
                    ),
                new Trasa(
                    new Stacja("Stacja J", new DateTime(2022,07,30,16,14,0), new DateTime(2022,07,30,16,16,30), 19),
                    new Stacja("Stacja 31", new DateTime(2022,07,30,20,30,0), new DateTime(2022,07,30,20,40,30), 99),
                    300, 41, 16
                    )

            };
            return miejsca;
        }

       

    }
}
