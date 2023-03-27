using GestoreEventi;


Evento evento = new Evento("Litfiba World Tour", new DateTime(2023, 4, 15),200);


evento.PrenotaPosti(20);

evento.DisdiciPosti(10);

Console.WriteLine(evento);


