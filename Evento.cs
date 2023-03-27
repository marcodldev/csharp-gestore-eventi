using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestoreEventi
{
    public class Evento
    {
        private string Titolo;
      

    /*    public Evento(string titolo, DateTime data, int maxCapacita)
        {
            this.titolo = titolo;
            this.data = data;
            this.maxCapacita = maxCapacita;
            this.postiPrenotati = 0;
        } */

        public Evento(string titolo, DateTime data)
        {
            this.titolo = titolo;
            this.data = data;
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
            get { return data; }
            set
            {
                if (value < DateTime.Today)
                    throw new ArgumentException("Seleziona una data valida.");
                data = value;
            }
        }

        /*
                public int maxCapacita {
                    get { return maxCapacita;}
                    set
                    {
                        if (maxCapacita < 0)
                        {
                            throw new ArgumentException("La capacità massima non puo' essere inferiore a 0.");
                        }
                        else
                        {
                            maxCapacita = value;
                        }
                    }
                }

                public int postiPrenotati
                {
                    get { return postiPrenotati; }
                    private set { postiPrenotati = value; }
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
                    return data.ToString("dd/MM/yyyy") + " - " + titolo;
                }
        */
        public override string ToString()
        {
            return $"Titolo: {titolo}, Data: {data}";
        }

    } 
}
