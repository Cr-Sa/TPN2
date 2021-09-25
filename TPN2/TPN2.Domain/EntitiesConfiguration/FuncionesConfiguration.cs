using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TPN2.Domain.Entities;
using System;

namespace TPN2.Domain.EntitiesConfiguration
{
    public class FuncionesConfiguration : IEntityTypeConfiguration<Funciones>
    {
        public void Configure(EntityTypeBuilder<Funciones> builder)
        {
            builder.HasKey(fun => fun.FuncionId);
            builder.Property(fun => fun.FuncionId)
                   .ValueGeneratedOnAdd();

            builder.Property(fun => fun.PeliculaId)
                   .IsRequired(true)
                   .HasMaxLength(50);


            builder.Property(fun => fun.SalaId)
                   .IsRequired(true)
                   .HasMaxLength(50);

            builder.Property(fun => fun.Fecha)
                   .IsRequired(true);

            builder.Property(fun => fun.Horario)
                   .IsRequired(true);

            builder.HasOne(pel => pel.Pelicula).WithMany(fun => fun.Funciones);

            builder.HasOne(sal => sal.Sala).WithMany(fun => fun.Funciones);

        }
    }
}
