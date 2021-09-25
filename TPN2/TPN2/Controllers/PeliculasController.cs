using Microsoft.AspNetCore.Mvc;
using TPN2.Application.Services;
using TPN2.Domain.DTOs;
using TPN2.Domain.Entities;
using System.Collections.Generic;

namespace TPN2.Controllers
{
    [Route("api/Peliculas")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        private readonly IPeliculasService _service;
        public PeliculasController(IPeliculasService service)
        {
            _service = service;
        }

        [HttpPost]
        public Peliculas Post(PeliculasDTO pelicula)
        {
            return _service.CreatePelicula(pelicula);
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