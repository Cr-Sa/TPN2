using Microsoft.AspNetCore.Mvc;
using TPN2.Application.Services;
using TPN2.Domain.DTOs;
using TPN2.Domain.Entities;
using System.Collections.Generic;
using System;

namespace TPN2.Controllers
{
    [Route("api/Funciones")]
    [ApiController]
    public class FuncionesController : ControllerBase
    {
        private readonly IFuncionesService _service;
        public FuncionesController(IFuncionesService service)
        {
            _service = service;
        }
        /// <summary>
        /// Crea una función
        /// </summary>
        /// <param name="funcion"></param>
        /// <returns>Retorna los datos de la función creada</returns>
        [HttpPost]
        public Funciones Post(FuncionesDTO funcion)
        {
            return _service.CreateFuncion(funcion);
        }
        /// <summary>
        /// Trae todas las funciones del dia indicado 
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="pelicula"></param>
        /// <returns>Retorna los datos de todas las funciones que corresponden a la fecha</returns>
        [HttpGet]
        public IList<FuncionesDTO> GetByFecha( [FromQuery] int pelicula) //[FromQuery] DateTime fecha,
        {
            return _service.GetByFecha( pelicula); //fecha,
        }

    }
}