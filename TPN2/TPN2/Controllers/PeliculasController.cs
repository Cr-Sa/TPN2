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
        /// <summary>
        /// Crea una película
        /// </summary>
        /// <param name="pelicula"></param>
        /// <returns>Retorna los datos de una pelicula creada</returns>
        [HttpPost]
        public PeliculasDTO Post(PeliculasDTO pelicula)
        {
            return _service.CreatePelicula(pelicula);
        }
        /// <summary>
        /// Trae una película por ID
        /// </summary>
        /// <param name="peliculaId"></param>
        /// <returns>Retorna los datos de una película en especifico</returns>
        [HttpGet("{peliculaId:int}")]
        public PeliculasDTO GetPeliculaById(int peliculaId)
        {
            return _service.GetById(peliculaId);
        }
    }
}