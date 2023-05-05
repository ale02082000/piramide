# Piramide




 ~~Il tuo compito oggi è scrivere un programma che calcoli l'altezza massima di una piramide (in piani) dato un certo numero di cubi di pietra.

Ipotizzando che:

- i piani della piramide siano quadrati
- la piramide da costruire sia compatta, cioè non ci siano cavità al suo interno. 
- ogni piano è quadrato, con una lunghezza laterale inferiore di due rispetto a quella sottostante.
- il primo piano è sempre di un mattone

Va bene se hai blocchi rimanenti, purché tu costruisca una piramide completa.

Sviluppare:

- il metodo int Piani( int mattoni ) che torna il numero di piani
- il metodo int Rimanenti( int mattoni ) che torna il numero di mattoni rimasti dopo la costruzione~~




``` c#
namespace Piramide
{
    public static class Piramide
    {


        public static int Piani(int mattoni)
        {


            if (mattoni < 1) return 0; // non è possibile costruire la piramide
            int piani = 1;
            int mattonirimanenti = mattoni;
            while (mattonirimanenti >= (2 * piani + 1) * (2 * piani + 1) - 2 * piani)
           
            {
                mattonirimanenti -= (2 * piani + 1) * (2 * piani + 1) - 2 * piani;
                piani++;
           
           
            }
            return piani;
        }

``` 
 ~~Il codice che hai mostrato implementa una funzione chiamata Piani all'interno della classe Piramide. La funzione prende un parametro intero chiamato mattoni e restituisce un intero che rappresenta il numero di piani che possono essere costruiti con il numero di mattoni forniti.

La funzione inizia verificando che il numero di mattoni forniti sia maggiore o uguale a 1, altrimenti restituisce 0 perché non sarebbe possibile costruire neanche un piano.

Successivamente, viene inizializzata una variabile intera piani con il valore 1, che rappresenta il numero di piani che abbiamo già costruito. Viene poi  inizializzata una variabile mattonirimanenti con il valore mattoni, che rappresenta il numero di mattoni rimasti per costruire la piramide.

Viene quindi eseguito un ciclo while che continua finché il numero di mattoni rimasti è sufficiente per costruire un ulteriore piano. La condizione del ciclo while controlla se il numero di mattoni rimasti è maggiore o uguale alla quantità di mattoni necessaria per costruire il piano successivo.

La quantità di mattoni necessaria per costruire il piano successivo viene calcolata utilizzando la formula (2 * piani + 1) * (2 * piani + 1) - 2 * piani. Questa formula rappresenta il numero totale di mattoni necessari per costruire il piano corrente, il perimetro del piano corrente ha 2 * piani + 1 mattoni per ogni lato, ma ci sono anche 2 * piani mattoni che si sovrappongono con il piano sottostante.

Se il numero di mattoni rimasti è sufficiente per costruire il piano successivo, viene sottratta la quantità di mattoni necessaria dal valore di mattonirimanenti e viene incrementato il valore di piani di 1. In questo modo, la funzione controlla il numero di piani che possono essere costruiti con i mattoni forniti.

Infine, la funzione restituisce il numero di piani che è stato possibile costruire. ~~

``` c#

public static int Rimanenti(int mattoni)
        {


            int piani = Piani(mattoni);
            int mattoni_necessari = (2 * piani - 1) * (2 * piani - 1);
         return mattoni - mattoni_necessari;


        }



    }
}


```



 ~~Il codice che hai mostrato implementa una funzione chiamata Rimanenti all'interno della classe Piramide. La funzione prende un parametro intero chiamato mattoni e restituisce un intero che rappresenta il numero di mattoni rimanenti dopo aver costruito la piramide con il numero di mattoni forniti.

La funzione inizia chiamando la funzione Piani (presumibilmente definita in un'altra parte del codice) con il parametro mattoni, che restituisce il numero di piani che possono essere costruiti con i mattoni forniti. Questo valore viene assegnato alla variabile piani.

Successivamente, viene calcolata la quantità di mattoni necessaria per costruire la piramide completa. La formula utilizzata per questo calcolo è (2 * piani - 1) * (2 * piani - 1), che tiene conto del fatto che la base della piramide ha 2 * piani - 1 mattoni per lato.

Infine, la funzione restituisce la differenza tra il numero di mattoni forniti e il numero di mattoni necessari per costruire la piramide completa. Questo valore rappresenta il numero di mattoni rimanenti dopo aver costruito la piramide. ~~
