using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_8
{
    class Magazin
    {
        public List<Bec> Becuri = new List<Bec>();
        public List<Televizor> Televizoare = new List<Televizor>();
        public List<Telefon> Telefoane = new List<Telefon>();
        /// <summary>
        /// Adugati produsul in lista de produse.
        /// </summary>
        /// <param name="bec"></param>
        public void AdaugaProdus(Bec bec)
        {
            if(bec == null)
            {
                throw new NullReferenceException();
            }

            Becuri.Add(bec);
        }
        public void AdaugaProdus(Telefon telefon)
        {
            if (telefon == null)
            {
                throw new NullReferenceException();
            }

            Telefoane.Add(telefon);
        }
        public void AdaugaProdus(Televizor televizor)
        {
            if (televizor == null)
            {
                throw new NullReferenceException();
            }

            Televizoare.Add(televizor);
        }



        CasaMarcat casaDeMarcat = new CasaMarcat();
        public Bec VanzareProdus(Bec bec)
        {
            if(Becuri.Contains(bec))
            {
                casaDeMarcat.Vanzare(bec);
                Becuri.Remove(bec);
            }
            else
            {
                Console.WriteLine("Becu nu este in stoc.");
            }
            return bec;
        }
        public Telefon VanzareProdus(Telefon telefon)
        {
            if (Telefoane.Contains(telefon))
            {
                casaDeMarcat.Vanzare(telefon);
                Telefoane.Remove(telefon);
            }
            else
            {
                Console.WriteLine("Telefonul nu este in stoc.");
            }
            return telefon;
        }
        public Televizor VanzareProdus(Televizor televizor)
        {
            if (Televizoare.Contains(televizor))
            {
                casaDeMarcat.Vanzare(televizor);
                Televizoare.Remove(televizor);
            }
            else
            {
                Console.WriteLine("Televizorul nu este in stoc.");
            }
            return televizor;
        }
        public int TrimiteValoareVanzari()
        {
            return casaDeMarcat.ValoareVanzari;
        }
    }
}
