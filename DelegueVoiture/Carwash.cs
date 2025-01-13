using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegueVoiture
{
    internal class Carwash : Voiture,IVoiture
    {
        

        public Carwash(string plaque) : base(plaque)
        {
        }

        public void Finaliser(Voiture v)
        {
            throw new NotImplementedException();
        }

        public void Laver(Voiture v)
        {
            throw new NotImplementedException();
        }

        public void Preparer(Voiture v)
        {
            throw new NotImplementedException();
        }

        public void Secher(Voiture v)
        {
            throw new NotImplementedException();
        }

        public void Traiter(Voiture v)
        {
            throw new NotImplementedException();
        }
    }
}
