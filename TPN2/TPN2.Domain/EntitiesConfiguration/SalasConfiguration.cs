using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TPN2.Domain.Entities;
using System;

namespace TPN2.Domain.EntitiesConfiguration
{
    public class SalasConfiguration : IEntityTypeConfiguration<Salas>
    {
        public void Configure(EntityTypeBuilder<Salas> builder)
        {
            builder.HasKey(sal => sal.SalaId);
            builder.Property(sal => sal.SalaId)
                   .ValueGeneratedOnAdd();

            builder.Property(sal => sal.Capacidad)
                   .IsRequired(true)
                   .HasMaxLength(35);

            builder.HasData(
                    new Salas { SalaId = 1, Capacidad = 5 },
                    new Salas { SalaId = 2, Capacidad = 15 },
                    new Salas { SalaId = 3, Capacidad = 35 }
                            );
        }
    }
}
