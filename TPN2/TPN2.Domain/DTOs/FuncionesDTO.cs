using System;

namespace TPN2.Domain.DTOs
{
    public class FuncionesDTO
    {
        public int PeliculaId { get; set; }
        public int SalaId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Horario { get; set; }
    }
}