using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_8
{
    class Telefon : Produs
    {
        public string Model { get; }
        public string Producator { get; set; }

        public Telefon(string model, string producator):base(1700)
        {
            this.Model = model;
            this.Producator = producator;
        }

        public void Deblocheaza()
        {
            Console.WriteLine("Telefonul este deblocat!");
        }

        public void Blocheaza()
        {
            Console.WriteLine("Telefonul este blocat!");
        }
    }
}
