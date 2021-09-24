using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TPN2.Domain.Entities;
using System;

namespace TPN2.Domain.EntitiesConfiguration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Funciones>
    {
        public void Configure(EntityTypeBuilder<Funciones> builder)
        {
            builder.ToTable("Funciones");
            builder.HasKey(fun => fun.FuncionId);
            builder.Property(fun => fun.PeliculaId).HasMaxLength(50).IsRequired();
            builder.Property(fun => fun.SalaId).HasMaxLength(50).IsRequired();
            builder.Property(fun => fun.Fecha).IsRequired();
            builder.Property(fun => fun.Horario).IsRequired();

            builder.HasOne(pel => pel.Pelicula).WithMany(fun => fun.Funciones);
            builder.HasOne(sal => sal.Sala).WithMany(fun => fun.Funciones);

        }
    }
}
