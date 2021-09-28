using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TPN2.Domain.Entities;
using System;

namespace TPN2.Domain.EntitiesConfiguration
{
    public class TicketsConfiguration : IEntityTypeConfiguration<Tickets>
    {
        public void Configure(EntityTypeBuilder<Tickets> builder)
        {
            builder.HasKey(compuesta => new { compuesta.TicketId, compuesta.FuncionId });

            builder.Property(tik => tik.Usuario)
                   .IsRequired(true)
                   .HasMaxLength(50);


            builder.Property(tik => tik.FuncionId)
                   .IsRequired(true);

            builder.HasOne(fun => fun.Funcion).WithMany(tik => tik.Tickets);

        }
    }
}
