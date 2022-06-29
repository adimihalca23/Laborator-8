using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_8
{
    class Produs
    {
        public int Pret { get; }

        public Produs(int pret)
        {
            if(pret <= 0)
            {
                throw new ArgumentException(nameof(pret), "Pretul trebuie sa fie mai mare decat 0!");
            }
            else
            {
                this.Pret = pret;
            }
            //Intrebare: Are sens "else" aici? Ca oricum se opreste executia cand se arunca exceptia.
        }
    }
}
