using System;
using System.Collections.Generic;

namespace TPN2.Domain.Entities
{
    public class Salas
    {
        public int SalaId { get; set; }
        public int Capacidad { get; set; }
        public virtual IList<Funciones> Funciones { get; set; }
    }
}