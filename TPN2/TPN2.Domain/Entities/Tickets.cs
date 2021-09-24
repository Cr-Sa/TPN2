using System;
using System.Collections.Generic;

namespace TPN2.Domain.Entities
{
    public class Tickets
    {
        public Guid TicketId { get; set; }
        public int FuncionId { get; set; }
        public string Usuario { get; set; }
        public Funciones Funcion { get; set; }
    }
}