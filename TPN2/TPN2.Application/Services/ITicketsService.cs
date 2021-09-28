using TPN2.Domain.DTOs;
using TPN2.Domain.Entities;
using System.Collections.Generic;

namespace TPN2.Application.Services
{
    public interface ITicketsService
    {
        Tickets CreateTickets(TicketsDTO ticket);
    }
}
