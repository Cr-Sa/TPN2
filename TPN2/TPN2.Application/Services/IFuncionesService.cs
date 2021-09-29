using TPN2.Domain.DTOs;
using TPN2.Domain.Entities;
using System.Collections.Generic;
using System;

namespace TPN2.Application.Services
{
    public interface IFuncionesService
    {
        Funciones CreateFuncion(FuncionesDTO funcion);
        IList<FuncionesDTO> GetByFecha( int pelicula); //DateTime fecha,
    }
}
