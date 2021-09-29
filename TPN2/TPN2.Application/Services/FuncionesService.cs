using TPN2.Domain.Commands;
using TPN2.Domain.DTOs;
using TPN2.Domain.Entities;
using TPN2.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace TPN2.Application.Services
{
    public class FuncionesService : IFuncionesService
    {
        private readonly IGenericsRepository _repository;
        private readonly IFuncionQuery _query;

        public FuncionesService(IGenericsRepository repository, IFuncionQuery query) 
        {
            _repository = repository;
            _query = query;
        }

        public Funciones CreateFuncion(FuncionesDTO funcion)
        {

            var entity = new Funciones
            {
                PeliculaId = funcion.PeliculaId,
                SalaId = funcion.SalaId,
                Fecha = funcion.Fecha,
                Horario = funcion.Horario
            };
            _repository.Add<Funciones>(entity);
            return entity;
        }
        public IList<FuncionesDTO> GetByFecha( int pelicula) //DateTime fecha,
        {
            IList<FuncionesDTO> funciones = _query.GetByFecha( pelicula); //fecha,
            List<FuncionesDTO> funcionesDisponibles = new List<FuncionesDTO>();
            foreach (var p in funciones)
            {
                funcionesDisponibles.Add(new FuncionesDTO(){

                
                Fecha = p.Fecha,
                Horario = p.Horario,
                PeliculaId = p.PeliculaId,
                SalaId = p.SalaId,
                });
            }
            return funcionesDisponibles;
        }
    }
}
