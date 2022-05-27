using System;
using System.Collections.Generic;

namespace PolTrain.Classes
{
    public class Wagon
    {

        public int Klasa { get; }
        public int IloscMiejsc { get; }
        public int WolneMiejsca { get; protected set; }
        public int ZajeteMiejsca { get; }
        public string TypWagonu { get; }
        public int NumerWagonu { get; }
        protected Pociag Pociag { get; }
        public List<Miejsce> Miejsca { set; get; } 
        public Wagon(int _klasa, string _typWagonu, int _numerWagonu, List<Miejsce> _miejsca= null)
        {
            Klasa = _klasa;
            TypWagonu = _typWagonu;
            NumerWagonu = _numerWagonu;
            if (_miejsca != null)
            {
                Miejsca = _miejsca;
                foreach(Miejsce miejsce in Miejsca)
                {
                    IloscMiejsc = Miejsca.Count;
                    if (miejsce.Zajete) ZajeteMiejsca++;
                    miejsce.Wagon = this;
                }
                WolneMiejsca = IloscMiejsc - ZajeteMiejsca;
            }
        }


        /// <summary>
        /// Zwraca <c>True</c> je�li zajmowanie miejsca zako�czy�o si� pomy�lnie.
        /// <c>False</c> w przypadku gdy nie uda�o si� zaj�� miejsca.
        /// </summary>
        public bool ZajmijMiejsce(Miejsce zajmowaneMiejsce)
        {
            if (WolneMiejsca > 0 & zajmowaneMiejsce.Zajete == false & Miejsca.Contains(zajmowaneMiejsce))
            {
                zajmowaneMiejsce.Zajete = true;
                WolneMiejsca -= 1;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Zwraca <c>True</c> je�li zwalnianie miejsca zako�czy�o si� pomy�lnie.
        /// <c>False</c> w przypadku gdy nie uda�o si� zwolni� miejsca.
        /// </summary>
        public bool ZwolnijMiejsce(Miejsce zwalnianeMiejsce)
        {
            if(ZajeteMiejsca > 0 & zwalnianeMiejsce.Zajete == true & Miejsca.Contains(zwalnianeMiejsce))
            {
                zwalnianeMiejsce.Zajete = false;
                WolneMiejsca += 1;
                return true;
            }
            return false;

        }


    }
}