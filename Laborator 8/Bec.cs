using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_8
{
    class Bec : Produs
    {
        public Bec():base(25)
        {
        }

        public void AprindeBec()
        {
            Console.WriteLine("Becul este aprins!");
        }

        public void StingeBec()
        {
            Console.WriteLine("Becul este stins!");
        }
    }
}
