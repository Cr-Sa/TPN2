using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPN2.Domain.DTOs;
using TPN2.Domain.Entities;
using TPN2.Domain.Queries;

namespace TPN2.AccessData.Queries
{
    public class PeliculaQuery : IPeliculaQuery
    {
        private readonly CinedbContext _context;
        public PeliculaQuery(CinedbContext context)
        {
            _context = context;
        }
        public PeliculasDTO GetById(int peliculaId)
        {
            var peliculas = _context.Peliculas
                .Where(c => c.PeliculaId == peliculaId)
                .Select(c => new PeliculasDTO
                {
                    PeliculaId = c.PeliculaId,
                    Titulo = c.Titulo,
                    Poster = c.Poster,
                    Sinopsis = c.Sinopsis,
                    Trailer = c.Trailer

                })
                .FirstOrDefault();
            return peliculas;
        }
    }
}
