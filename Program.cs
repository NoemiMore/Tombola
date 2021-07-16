using System;

namespace Tombola
{
    class Program
    {
        //definire una funzione che restituisce un valore al codice
        //chiamante tramite l’istruzione Return;

        //utilizzare la classe Random per la generazione di numeri pseudo-casuali;




        /*
         Creare una Console App che simuli il gioco della tombola.
1) La console deve dare un benvenuto all’utente: “Benvenuto a Tombola!”
2) L’utente deve inserire 5 numeri da tastiera (numero costante N=5). (Opzionale N=15).
Controllo: L’utente non può inserire due numeri uguali. Può inserire solo numeri compresi tra 1 e 90.
Una volta scelti, i numeri inseriti dall’utente devono essere mostrati a schermo.
3) (Opzionale) L’utente deve scegliere il livello di difficoltà del gioco tra:
• Facile: verranno estratti 70 numeri
• Medio: verranno estratti 40 numeri
• Difficile: verranno estratti 20 numeri
N.B. Se si decide di saltare la scelta del livello, scegliere, a piacere, se estrarre 70, 40 o 20 numeri.
4) Devono essere estratti i numeri random (70, 40 o 20 in base alla scelta del livello di difficoltà) compresi
tra 1 e 90.
Attenzione: Non deve essere possibile estrarre due numeri uguali.
5) L’utente ha vinto se i suoi numeri sono tra quelli estratti e in particolare:
- se i numeri corrispondenti sono 2, dovrà essere scritto a terminale la frase: “Hai fatto ambo!”
- se i numeri corrispondenti sono 3, dovrà essere scritto a terminale la frase: “Hai fatto terno!”
- se i numeri corrispondenti sono 4, dovrà essere scritto a terminale la frase “Hai fatto
quaterna!”
- se i numeri corrispondenti sono 5, dovrà essere scritto a terminale la frase “Hai fatto cinquina!”
(Opzionale, nel caso in cui N=15, ovvero si decide di far inserire 15 numeri all’utente bisogna
considerare anche i seguenti casi:
- se i numeri corrispondenti sono 15, dovrà essere scritto a terminale la frase: “Hai fatto
tombola!”
- Se i numeri corrispondenti sono compresi tra 6 e 14 l’utente ha comunque fatto cinquina.)
6) Dovranno essere scritti a schermo i numeri vincenti (cioè i numeri vincenti dell’utente)
7) Se l’utente ha “beccato” meno di 2 numeri corrispondenti, dovrà essere scritto a terminale “hai
perso…”
L’utente può decidere di tentare di nuovo la fortuna e rigiocare a tombola.
N.B. Il Benvenuto dovrà essere mostrato solo al primo avvio dell’applicazione.
(Opzionale: Colorare la frase di benvenuto. Farsi “aiutare da Google” ).
Suggerimento:
Creare funzioni per: Scelta dei Numeri, Scelta della Difficoltà, Estrazione dei Numeri, Controllo della Vittoria (da
chiamare nel Main).
         */
        //generare una scansione dei controlli presenti nel form(Me.Controls) attraverso il costrutto For Each … Next per evidenziare le caselle corrispondenti ai numeri estratti.
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto a Tombola!");
           
            Console.WriteLine("Inserisci 5 numeri da giocare");
            int n = 5;


           
            sceltaNumeriUtente();
            int[] numScelti = sceltaNumeriUtente();
            Console.WriteLine($"Hai scelto i seguenti numeri {numScelti[n]}");

            sceltaDifficoltà();

            int sceltaDiffUtente = mostraScelte();
            Console.WriteLine($"Hai scelto una partita di gioco: {numScelti[n]}");

            estrazNumeri();
            int [] numeriEstr= estrazNumeri();
            Console.WriteLine($"I numeri estratti dal Computer sono {sceltaDiffUtente}");


            verificaVittoriaUtente(estrazNum, SceltaNumeriUtente);
            bool risultatoPartita = verificaVittoriaUtente();

        }

        private static int[] estrazNumeri()
        {
            int[] numEstratti = new int[5];
            int num = 5;

            for (int x = 1; x <= 5; x++) { numEstratti[x] = x; }

            for (int estraz = 1; estraz <= 5; estraz++)
            {

                Random random = new Random();
                int casuale = random.Next(1, 91);
                int estratto = Array.IndexOf(numEstratti, casuale);

                if (casuale != num - 1)
                {
                    numEstratti[num - 1] ^= numEstratti[estratto];
                    numEstratti[estratto] ^= numEstratti[num - 1];
                    numEstratti[num - 1] ^= numEstratti[estratto];
                }
                Console.WriteLine(estraz + "° estratto = " + estratto);
                num = num - 1;
            }
            Console.ReadLine();
            return numEstratti[];
    }

        private static int mostraScelte()
        {
            Console.WriteLine("\nFai la tua scelta tra:");
            Console.WriteLine($"1 per {difficoltà.facile}");
            Console.WriteLine($"2 per {difficoltà.media}");
            Console.WriteLine($"3 per {difficoltà.difficile}\n");
            int SceltaUt = int.Parse( Console.ReadLine());
            return SceltaUt;
        }

        private static void sceltaDifficoltà()
        {
           
        }


        private static bool verificaVittoriaUtente(estrazNumeri(), sceltaNumeriUtente(n);)
        {
            bool vittoria = false;

            if (SceltaNumeriUtente == EstrazNum)
            {
                vittoria = true;
            }
            

            return vittoria;

        }


        //scelta  numeri con controllo che non siano uguali e tra 0 e 90
        private static int[] sceltaNumeriUtente()
        {
           

             


            for (int i = 0; i < numeri.Length; i++)
            {
                Console.WriteLine($"Inserisci il {i + 1}° numero");
                int numero;
                while (!int.TryParse(Console.ReadLine(), out numero) || n > 0 || n < 90)
                {
                    Console.WriteLine("Devi inserire un numero compreso tra 1 e 90. Riprova:");
                }
                int[] numeri = new int[numero];

                int Prova = Array.IndexOf(numeri, numero);
                if (Prova > -1)
                {
                    Console.WriteLine($"Mi dispiace hai già scelto il numero{numero}");
                    i--;
                }
            }
                     return numeri;
                  }
        {
        }

        

        
   
    


       
    public enum difficoltà
        {
            facile = 1,
            media = 2,
            difficile = 3
        }
    }
}


