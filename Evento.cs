using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace GestoreEventi
{
    public record Evento
    {
        private string Titolo;
        private DateTime Data;
        private int MaxCapacita;
        private int PostiPrenotati;

        public Evento(string titolo, DateTime data, int MaxCapacita)
        {
            this.titolo = titolo;
            this.data = data;
            this.maxCapacita = MaxCapacita;
            PostiPrenotati = 0;
        }

        public string titolo
        {
            get { return Titolo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Il titolo non può essere vuoto.");
                   // Console.WriteLine("Il titolo non può essere vuoto.");
                }
                else
                {
                    Titolo = value;
                }
            }
        }

        public DateTime data
        {
            get { return Data; }
            set
            {
                if (value < DateTime.Today)
                    throw new ArgumentException("Seleziona una data valida.");
                Data = value;
            }
        }

        
                public int maxCapacita {
                    get { return MaxCapacita; }
                    set
                    {
                        if (MaxCapacita < 0)
                        {
                            throw new ArgumentException("La capacità massima non puo' essere inferiore a 0.");
                        }
                        else
                        {
                    MaxCapacita = value;
                        }
                    }
                }

                public int postiPrenotati
                {
                    get { return PostiPrenotati; }
                    private set { PostiPrenotati = value; }
                }



                public void PrenotaPosti(int postiDaPrenotare)
                {
                    if (DateTime.Today > data || maxCapacita == 0 || postiDaPrenotare > maxCapacita - postiPrenotati)
                        throw new InvalidOperationException("Impossibile prenotare i posti richiesti.");
                    postiPrenotati += postiDaPrenotare;
                }

                public void DisdiciPosti(int postiDaDisdire)
                {
                    if(DateTime.Today > data || postiDaDisdire > postiPrenotati)
                    {
                        throw new InvalidOperationException("Impossibile disdire.");
                    }
                    postiPrenotati -= postiDaDisdire;
                }
   
                public override string ToString()
                {
                    return data.ToString("dd/MM/yyyy") + " - " + titolo + " - " + " Posti massimi:" + maxCapacita + " Posti prenotati:" + postiPrenotati;
                    
                }

       
    } 
}
