using TPN2.Domain.Commands;
using TPN2.Domain.DTOs;
using TPN2.Domain.Entities;
using TPN2.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace TPN2.Application.Services
{
    public class PeliculasService : IPeliculasService
    {
        private readonly IGenericsRepository _repository;
        //private readonly IClienteQuery _query;

        public PeliculasService(IGenericsRepository repository) //, IClienteQuery query
        {
            _repository = repository;
            //_query = query;
        }

        public Peliculas CreatePelicula(PeliculasDTO pelicula)
        {

            var entity = new Peliculas
            {
                PeliculaId = pelicula.PeliculaId,
                Titulo = pelicula.Titulo,
                Poster = pelicula.Poster,
                Sinopsis = pelicula.Sinopsis,
                Trailer = pelicula.Trailer
            };
            _repository.Add<Peliculas>(entity);
            return entity;
        }     
        //public IList<ClienteDTO> GetAll()
        //{
        //    return _query.GetAll();
        //}
        //public Cliente GetById(int clienteId)
        //{
        //    return _query.GetById(clienteId);
        //}
    }
}
