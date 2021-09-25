﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]
        public Funciones Post(FuncionesDTO funcion)
        {
            return _service.CreateFuncion(funcion);
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