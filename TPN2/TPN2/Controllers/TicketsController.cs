using Microsoft.AspNetCore.Mvc;
using TPN2.Application.Services;
using TPN2.Domain.DTOs;
using TPN2.Domain.Entities;
using System.Collections.Generic;

namespace TPN2.Controllers
{
    [Route("api/Tickets")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketsService _service;
        public TicketsController(ITicketsService service)
        {
            _service = service;
        }

        [HttpPost]
        public Tickets Post(TicketsDTO ticket)
        {
            return _service.CreateTickets(ticket);
        }

        //[HttpGet]
        //public IList<ClienteDTO> GetClientes()
        //{
        //    return _service.GetAll();
        //}

        //[HttpGet("{clienteId:int}")]
        
        //public Cliente GetClienteById(int clienteId)
        //{
        //    return _service.GetById(clienteId);
        //}
    }
}