using TPN2.Domain.DTOs;
using TPN2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace TPN2.Domain.Queries
{
    public interface IFuncionQuery
    {
        IList<FuncionesDTO> GetByFecha(int pelicula); //DateTime fecha, 
    }
}
