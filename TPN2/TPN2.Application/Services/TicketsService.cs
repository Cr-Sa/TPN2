using TPN2.Domain.Commands;
using TPN2.Domain.DTOs;
using TPN2.Domain.Entities;
//using TPN2.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace TPN2.Application.Services
{
    public class TicketsService : ITicketsService
    {
        private readonly IGenericsRepository _repository;
        //private readonly IClienteQuery _query;

        public TicketsService(IGenericsRepository repository) //, IClienteQuery query
        {
            _repository = repository;
            //_query = query;
        }

        public Tickets CreateTickets(TicketsDTO ticket)
        {

            var entity = new Tickets
            {
                FuncionId = ticket.FuncionId,
                Usuario = ticket.Usuario
            };
            _repository.Add<Tickets>(entity);
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
