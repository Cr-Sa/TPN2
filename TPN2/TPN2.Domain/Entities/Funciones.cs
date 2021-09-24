using System;
using System.Collections.Generic;

namespace TPN2.Domain.Entities
{
    public class Funciones
    {
        public int FuncionId { get; set; }
        public int PeliculaId { get; set; }
        public int SalaId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Horario { get; set; }
        public Peliculas Pelicula { get; set; }
        public Salas Sala { get; set; }
        public virtual IList<Tickets> Tickets { get; set; }
    }
}