using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    using System;
    using System.Collections.Generic;

    public class ProgrammaEventi
    {
        public string Titolo { get; }
        public List<Evento> Eventi { get; }

        public ProgrammaEventi(string titolo)
        {
            Titolo = titolo;
            Eventi = new List<Evento>();
        }

        public void AggiungiEvento(Evento evento)
        {
            Eventi.Add(evento);
        }

        public List<Evento> EventiInData(DateTime data)
        {
            List<Evento> eventiInData = new List<Evento>();
            foreach (Evento evento in Eventi)
            {
                if (evento.data == data)
                {
                    eventiInData.Add(evento);
                }
            }
            return eventiInData;
        }

        public static string ListaEventiToString(List<Evento> eventi)
        {
            string str = "";
            foreach (Evento evento in eventi)
            {
                str += evento.data.ToShortDateString() + " - " + evento.titolo + "\n";
            }
            return str;
        }


        public int NumeroEventi()
        {
            return Eventi.Count;
        }

        public void SvuotaEventi()
        {
            Eventi.Clear();
        }

        public override string ToString()
        {
            string str = "Nome programma evento: " + Titolo + "\n";
            foreach (Evento evento in Eventi)
            {
                str += evento.data.ToShortDateString() + " - " + evento.titolo + "\n";
            }
            return str;
        }

        public static void StampaListaEventi(List<Evento> eventi)
        {
            if (eventi.Count == 0)
            {
                Console.WriteLine("Non ci sono eventi in questa data.");
            }
            else
            {
                foreach (Evento evento in eventi)
                {
                    Console.WriteLine("- " + evento.ToString());
                }
            }
        }
    }



}
