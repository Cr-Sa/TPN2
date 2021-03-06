using TPN2.Domain.DTOs;
using TPN2.Domain.Entities;
using System.Collections.Generic;

namespace TPN2.Application.Services
{
    public interface IPeliculasService
    {
        PeliculasDTO CreatePelicula(PeliculasDTO pelicula);
        PeliculasDTO GetById(int peliculaId);
    }
}
