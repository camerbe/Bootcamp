namespace DelegueVoiture
{
    public class Voiture
    {
        public string Plaque { get; private set; } = string.Empty;
        public Voiture(string plaque)
        {
            Plaque = plaque;
        }
    }
}
