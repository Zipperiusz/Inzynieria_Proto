namespace PolTrain.Classes
{
    public class Miejsce
    {

        public int NumerMiejsca { get; }
        public bool Specjalne { get; }
        public bool Zajete { get; }
        public Wagon Wagon { get;  }    
        public Bilet Bilet { get; }
        public Miejsce(int _numerMiejsca, bool _specjalne, bool _zajete)
        {
            NumerMiejsca = _numerMiejsca;
            Specjalne = _specjalne;
            Zajete = _zajete;
        }

    }
}