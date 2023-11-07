using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCassa

/*
ESERCIZIO CASSA

Creare una classe cassa che serva a rappresentare la cassa di un negozio; 
ogni cassa conserva una quantità di denaro all’interno che può aumentare nel tempo man mano che i clienti effettuano acquisti, 
la cassa ogni giorno memorizza il numero di acquisti del negozio. 
A fine giornata si dà alla cassa il comando “chiusura cassa” che riporta la quantità di denaro presente in cassa a una quantità iniziale “fondo cassa”, 
restituendo quando incassato e azzera il numero di acquisti, predisponendo la cassa per il suo uso nel giorno successivo. 
NB: la cassa non mantiene in memoria quanti acquisti sono stati fatti nei giorni precedenti.
Si creino anche i relativi metodi set e get dove sensato.

Creare un main che crei un’istanza di cassa e la provi con un menu che chiede cosa fare*/

{
    class Cassa
    {
        protected int qtaSoldi;
        protected int fondoCassa;
        protected int numScontrini;
        public int entrate;
        protected int numArticoli;
        protected int subTotale;
        public Stampante recuperaDati;

        public Cassa(int fondoC = 100)
        {
            this.qtaSoldi = 0;
            this.fondoCassa = fondoC;
            this.qtaSoldi = this.fondoCassa;
            this.numScontrini = 0;
            this.subTotale = 0;
            this.entrate = 0;
            this.numArticoli = 0;
            recuperaDati = new Stampante();
        }

        public void Battiacquisto(int entrate)
        {
            this.numArticoli++;
            this.entrate = entrate;
            this.subTotale += entrate;
            this.qtaSoldi += entrate;

            VisualizzaBattituraAcquisti();
        }

        private void VisualizzaBattituraAcquisti()
        {
            recuperaDati.StampaT("\n n. art " + this.numArticoli + "   prezzo   " + this.entrate + "$");
  
        }

        public void EmettiScontrino()
        {
            this.numScontrini++;
            recuperaDati.StampaT("\n Sub Totale: " + this.subTotale + "$\n Scontrino num: " + this.numScontrini);
           
            Console.WriteLine();
            this.subTotale = 0;
            this.numArticoli = 0;
        }

        public void EmettiChiusuraCassa()
        {
            ResetNumAcquisti();

            recuperaDati.StampaT("\n\n CHIUSURA CASSA:\n Totale soldi presenti in cassa: " + this.qtaSoldi + "$\n Totale incasso odierno: " + (this.qtaSoldi - this.fondoCassa) + "$\n");

        }

        private void ResetNumAcquisti()
        {
            this.numScontrini = 0;
        }
            
    }
}
