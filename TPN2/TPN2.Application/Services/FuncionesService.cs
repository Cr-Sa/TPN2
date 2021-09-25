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
        //private readonly IClienteQuery _query;

        public FuncionesService(IGenericsRepository repository) //, IClienteQuery query
        {
            _repository = repository;
            //_query = query;
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
