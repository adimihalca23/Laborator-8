using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_8
{
    class CasaMarcat
    {
        public int NumarVanzari { get; set; } = 0;
        public int ValoareVanzari { get; set; } = 0;

        public void Vanzare(Bec bec)
        {
            if(bec == null)
            {
                throw new NullReferenceException(nameof(bec));
            }

            NumarVanzari++;
            ValoareVanzari += bec.Pret;

        }
        public void Vanzare(Telefon telefon)
        {
            if (telefon == null)
            {
                throw new NullReferenceException(nameof(telefon));
            }

            NumarVanzari++;
            ValoareVanzari += telefon.Pret;

        }
        public void Vanzare(Televizor televizor)
        {
            if (televizor == null)
            {
                throw new NullReferenceException(nameof(televizor));
            }

            NumarVanzari++;
            ValoareVanzari += televizor.Pret;

        }
        
    }
}
