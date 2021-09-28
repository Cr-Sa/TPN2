using Microsoft.AspNetCore.Mvc;
using TPN2.Application.Services;
using TPN2.Domain.DTOs;
using TPN2.Domain.Entities;
using System.Collections.Generic;

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
    }
}