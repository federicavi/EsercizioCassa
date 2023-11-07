using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCassa
{
    class Program
    {
        static void Main(string[] args)
        {
            Cassa cassa1 = new Cassa();

            cassa1.Battiacquisto(20);
            cassa1.Battiacquisto(90);
            cassa1.Battiacquisto(60);
            cassa1.EmettiScontrino();

            cassa1.Battiacquisto(10);
            cassa1.Battiacquisto(6);
            cassa1.Battiacquisto(43);
            cassa1.Battiacquisto(32);
            cassa1.EmettiScontrino();

            cassa1.EmettiChiusuraCassa();

            cassa1.Battiacquisto(32);
            cassa1.EmettiScontrino();

            cassa1.Battiacquisto(6);
            cassa1.Battiacquisto(60);
            cassa1.EmettiScontrino();


            Console.ReadLine();
        }
    }
}
