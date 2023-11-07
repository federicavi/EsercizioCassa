
README - EsercizioCassa

Questo progetto rappresenta una simulazione di una cassa di negozio in C#.
La classe Cassa è progettata per gestire le operazioni di acquisto e chiusura della cassa in un negozio.

La classe Cassa ha i seguenti attributi:

qtaSoldi: La quantità di denaro attualmente presente in cassa.
fondoCassa: La quantità iniziale di denaro nella cassa all'inizio della giornata.
numScontrini: Il numero di scontrini emessi durante la giornata.
entrate: L'importo dell'ultimo acquisto.
numArticoli: Il numero totale di articoli venduti durante la giornata.
subTotale: L'importo totale degli acquisti durante la giornata.
recuperaDati: Un'istanza di una classe Stampante per la stampa dei dati.


La classe Cassa ha i seguenti metodi:

Battiacquisto(int entrate): Registra un nuovo acquisto, aggiorna l'importo totale, e visualizza l'acquisto.
EmettiScontrino(): Emette uno scontrino con l'importo totale e il numero di scontrino.
EmettiChiusuraCassa(): Chiude la cassa per la giornata, mostra il totale dei soldi presenti in cassa e l'incasso giornaliero.
ResetNumAcquisti(): Azzera il numero di scontrini emessi.


Utilizzo

Il codice include un esempio di utilizzo della classe Cassa in un'applicazione di console. 
Un'istanza di Cassa viene creata e viene simulata la registrazione di acquisti e la chiusura della cassa.
