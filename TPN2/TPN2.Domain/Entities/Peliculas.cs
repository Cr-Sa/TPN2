﻿using System;
using System.Collections.Generic;

namespace TPN2.Domain.Entities
{
    public class Peliculas
    {
        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Poster { get; set; }
        public string Sinopsis { get; set; }
        public string Trailer { get; set; }
        public virtual IList<Funciones> Funciones { get; set; }

    }
}