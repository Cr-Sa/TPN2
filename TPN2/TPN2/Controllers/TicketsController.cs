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
        /// <summary>
        /// Crea un Ticket
        /// </summary>
        /// <param name="ticket"></param>
        /// <returns>Retorna los datos de la función creada</returns>
        [HttpPost]
        public Tickets Post(TicketsDTO ticket)
        {
            return _service.CreateTickets(ticket);
        }
    }
}