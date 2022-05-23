namespace PolTrain.Classes
{
    public class Miejsce
    {

        public int NumerMiejsca;
        public bool Specjalne;
        public bool Zajete;

        public Miejsce(int _numerMiejsca, bool _specjalne, bool _zajete)
        {
            NumerMiejsca = _numerMiejsca;
            Specjalne = _specjalne;
            Zajete = _zajete;
        }

    }
}