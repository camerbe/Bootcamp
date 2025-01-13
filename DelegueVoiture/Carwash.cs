using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegueVoiture
{
    internal class Carwash 
    {
        
        private void Finaliser(Voiture v)
        {
            Console.WriteLine($"Je finalise la voiture : {v.Plaque}");
        }

        private void Laver(Voiture v)
        {
            Console.WriteLine($"Je lave la voiture : {v.Plaque}");
        }

        private void Preparer(Voiture v)
        {
            Console.WriteLine($"Je prépare la voiture : {v.Plaque}");
        }

        public void Secher(Voiture v)
        {
            Console.WriteLine($"Je sèche la voiture : {v.Plaque}");
        }

        public void Traiter(Voiture v)
        {
            TraitementVoiture traitement = Preparer;
            traitement += Laver;
            traitement += Secher;
            traitement += Finaliser;
        }
    }
}
