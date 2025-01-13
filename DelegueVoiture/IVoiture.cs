using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegueVoiture
{
    internal interface IVoiture
    {
        void Preparer(Voiture v);
        void Laver(Voiture v);
        void Secher(Voiture v);
        void Finaliser(Voiture v);
        void Traiter(Voiture v);
        
    }
}
