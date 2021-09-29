using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPN2.Domain.DTOs;
using TPN2.Domain.Entities;
using TPN2.Domain.Queries;

namespace TPN2.AccessData.Queries
{
    public class FuncionQuery : IFuncionQuery
    {
        private readonly CinedbContext _context;
        public FuncionQuery(CinedbContext context)
        {
            _context = context;
        }
        public IList<FuncionesDTO> GetByFecha(int pelicula) //DateTime fecha, 
        {
            var dias = _context.Funciones
                .Where(c =>  c.PeliculaId == pelicula) //c.Fecha == fecha &&
                .Select(c => new FuncionesDTO
                {
                    PeliculaId = c.PeliculaId,
                    SalaId = c.SalaId,
                    Fecha = c.Fecha,
                    Horario = c.Horario
                }).ToList();
            return dias;
        }
    }
}
