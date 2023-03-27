using GestoreEventi;

// evento di prova

Evento evento = new Evento("Litfiba World Tour", new DateTime(2023, 4, 15),200);

//

// comandi richiesti all'utente

/*
Console.Write("Inserisci il titolo dell'evento: ");
string titolo = Console.ReadLine();

Console.Write("Inserisci la data dell'evento (formato italiano): ");
DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

Console.Write("Inserisci la capienza massima dell'evento: ");
int maxposti = int.Parse(Console.ReadLine());

// evento con input dell'utente

Evento evento2 = new Evento(titolo, data, maxposti);

Console.Write("Inserisci numero di prenotazioni: ");
evento2.PrenotaPosti(int.Parse(Console.ReadLine()));

Console.Write("Vuoi disdire un posto?: ");
evento2.DisdiciPosti(int.Parse(Console.ReadLine()));



Console.WriteLine(evento2);
*/
// Programma eventi

ProgrammaEventi programma = new ProgrammaEventi("Eight Days Music");

programma.AggiungiEvento(new Evento("Weezer",new DateTime(2023,7,16),400));

programma.AggiungiEvento(new Evento("Green Day", new DateTime(2023, 7, 16), 400));

programma.AggiungiEvento(new Evento("Liam Gallagher", new DateTime(2023, 7, 17), 400));

programma.AggiungiEvento(new Evento("Guns n' Roses", new DateTime(2023, 7, 17), 400));


//  Ricerca per data
Console.WriteLine("Eventi in data 16/07/2023: ");

List<Evento> eventiInData = programma.EventiInData(new DateTime(2023, 7, 16));
Console.WriteLine(ProgrammaEventi.ListaEventiToString(eventiInData));


Console.WriteLine(programma);

/* Numero di eventi nel programma
int numeroEventi = programma.NumeroEventi();
Console.WriteLine("Numero totale di eventi: " + numeroEventi);

Console.WriteLine(programma);  */

/* Svuotamento della lista di eventi
programma.SvuotaEventi();
Console.WriteLine("Lista di eventi svuotata");

// Stampa del programma eventi dopo averlo svuotato
Console.WriteLine(programma);  */



//--------------------------------------------\\

Console.Write("Inserisci il titolo del tuo programma eventi: ");
string titolo = Console.ReadLine();
ProgrammaEventi programma2 = new ProgrammaEventi(titolo);

Console.Write("Quanti eventi vuoi aggiungere al tuo programma? ");
int numEventi = int.Parse(Console.ReadLine());

int i = 0;

while (i < numEventi)
{
    Console.WriteLine("Inserisci i dettagli dell'evento #" + (i + 1));
    Console.Write("Titolo: ");
    string titoloEvento = Console.ReadLine();

    Console.Write("Data (formato gg/mm/aaaa): ");
    DateTime dataEvento = DateTime.Parse(Console.ReadLine());

    Console.Write("Capacità massima: ");

    int maxCapacita = Convert.ToInt32(Console.ReadLine());


    Evento eventoNew = new Evento(titoloEvento, dataEvento, maxCapacita);
    programma2.AggiungiEvento(eventoNew);

    i++;
}


Console.WriteLine();
Console.WriteLine("Numero di eventi presenti nel programma: " + programma2.NumeroEventi());
Console.WriteLine("Ecco la lista dei tuoi eventi:");
Console.WriteLine(programma2.ToString());

Console.Write("Inserisci una data per visualizzare gli eventi in quella data (formato gg/mm/aaaa): ");

DateTime dataRichiesta = DateTime.Parse(Console.ReadLine());
List<Evento> eventiData = programma2.EventiInData(dataRichiesta);

Console.WriteLine("Eventi in data " + dataRichiesta.ToShortDateString() + ":");
ProgrammaEventi.StampaListaEventi(eventiData);

//  elimina tutti gli eventi 
programma2.SvuotaEventi();
Console.WriteLine("Tutti gli eventi sono stati eliminati dal programma.");

Console.WriteLine(programma2.ToString());