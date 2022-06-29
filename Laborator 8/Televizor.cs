using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_8
{
    class Televizor : Produs
    {
        public string Model { get; }
        public string Producator { get; }

        public Televizor(string model, string producator) : base(1000)
        {
            this.Model = model;
            this.Producator = producator;
        }

        public void PornesteTv()
        {
            Console.WriteLine("Televizorul este pornit pe canalul KissTv!");
        }

        public void OpresteTv()
        {
            Console.WriteLine("Televizorul este oprit!");
        }
    }
}
