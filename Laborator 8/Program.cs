using System;

namespace Laborator_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1();
        }


        static void Ex1()
        {
            Bec bec1 = new Bec();
            Bec bec2 = new Bec();
            Bec bec3 = new Bec();
            Bec bec4 = new Bec();
            Bec bec5 = new Bec();

            Televizor televizor1 = new Televizor("50AU7172", "Samsung");
            Televizor televizor2 = new Televizor("55UP75003LF", "LG");
            Televizor televizor3 = new Televizor("43PUS8536/12", "Philips");
            Televizor televizor4 = new Televizor("77A83J", "Sony");
            Televizor televizor5 = new Televizor("43Q60A", "Samsung");

            Telefon telefon1 = new Telefon("P30", "Huawei");
            Telefon telefon2 = new Telefon("Galaxy", "Samsung");
            Telefon telefon3 = new Telefon("105", "Nokia");
            Telefon telefon4 = new Telefon("Edge", "Motorola");
            Telefon telefon5 = new Telefon("P40", "Huawei");

            Magazin magazin = new Magazin();

            magazin.AdaugaProdus(bec1);
            magazin.AdaugaProdus(bec2);
            magazin.AdaugaProdus(bec3);
            magazin.AdaugaProdus(bec4);
            magazin.AdaugaProdus(bec5);
            
            magazin.AdaugaProdus(televizor1);
            magazin.AdaugaProdus(televizor2);
            magazin.AdaugaProdus(televizor3);
            magazin.AdaugaProdus(televizor4);
            magazin.AdaugaProdus(televizor5);

            magazin.AdaugaProdus(telefon1);
            magazin.AdaugaProdus(telefon2);
            magazin.AdaugaProdus(telefon3);
            magazin.AdaugaProdus(telefon4);
            magazin.AdaugaProdus(telefon5);
            

            foreach(Bec bec in magazin.Becuri)
            {
                bec.AprindeBec();
            }
            foreach (Telefon telefon in magazin.Telefoane)
            {
                telefon.Deblocheaza();
            }
            foreach (Televizor televizor in magazin.Televizoare)
            {
                televizor.PornesteTv();
            }


            magazin.VanzareProdus(bec2);
            magazin.VanzareProdus(televizor4);
            magazin.VanzareProdus(telefon1);

            int nr = magazin.TrimiteValoareVanzari();
            Console.WriteLine(nr);

            foreach (Bec bec in magazin.Becuri)
            {
                bec.StingeBec();
            }
            foreach (Telefon telefon in magazin.Telefoane)
            {
                telefon.Blocheaza();
            }
            foreach (Televizor televizor in magazin.Televizoare)
            {
                televizor.OpresteTv();
            }
        }
    }
}
