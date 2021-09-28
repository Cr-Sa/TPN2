using TPN2.Domain.Commands;
using TPN2.Domain.DTOs;
using TPN2.Domain.Entities;
//using TPN2.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Reflection;
using TPN2.Domain.Queries;

namespace TPN2.Application.Services
{
    public class PeliculasService : IPeliculasService
    {
        private readonly IGenericsRepository _repository;
        private readonly IPeliculaQuery _query;

        public PeliculasService(IGenericsRepository repository, IPeliculaQuery query)
        {
            _repository = repository;
            _query = query;
        }

        public PeliculasDTO CreatePelicula(PeliculasDTO pelicula)
        {

            var entity = new PeliculasDTO
            {
                PeliculaId = pelicula.PeliculaId,
                Titulo = pelicula.Titulo,
                Poster = pelicula.Poster,
                Sinopsis = pelicula.Sinopsis,
                Trailer = pelicula.Trailer
            };
            _repository.Add<PeliculasDTO>(entity);
            return entity;
        }
        public PeliculasDTO GetById(int peliculaId)
        {
            return _query.GetById(peliculaId);
        }
    }
}
