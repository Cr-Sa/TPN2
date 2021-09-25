using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TPN2.Domain.Entities;
using System;

namespace TPN2.Domain.EntitiesConfiguration
{
    public class PeliculasConfiguration : IEntityTypeConfiguration<Peliculas>
    {
        public void Configure(EntityTypeBuilder<Peliculas> builder)
        {
            builder.HasKey(pel => pel.PeliculaId);
            builder.Property(pel => pel.PeliculaId)
                   .ValueGeneratedOnAdd();

            builder.Property(fun => fun.PeliculaId)
                   .IsRequired(true)
                   .HasMaxLength(50);


            builder.Property(pel => pel.Titulo)
                   .IsRequired(true)
                   .HasMaxLength(50);

            builder.Property(pel => pel.Poster)
                   .IsRequired(true)
                   .HasMaxLength(255);

            builder.Property(pel => pel.Sinopsis)
                   .IsRequired(true)
                   .HasMaxLength(255);

            builder.Property(pel => pel.Trailer)
                   .IsRequired(true)
                   .HasMaxLength(255);

            builder.HasData(
                    new Peliculas { PeliculaId = 1, Titulo = "Star Wars:Episodio IV Una nueva esperanza", Poster = "https://es.web.img3.acsta.net/c_310_420/medias/nmedia/18/71/18/12/20061511.jpg", Sinopsis = "Leia es capturada por las tropas imperiales, antes de ser atrapada logra colocar el mensaje en R2D2. Al llegar a Tattooine junto con C3PO son capturados y vendidos al joven Luke Skywalker, quien descubrirá el mensaje oculto para salvar a Leia.", Trailer = "https://youtu.be/_sQSHZ65fPI" },
                    new Peliculas { PeliculaId = 2, Titulo = "Star Wars:Episodio V El imperio contraataca", Poster = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTAFLmt-Hfy6valTAd6sdWx0GcUYd-qS_Bkd4-Tk7_pGOa7DLEd", Sinopsis = "Aunque la Estrella de la Muerte ha sido destruida, las tropas imperiales han hecho salir a las fuerzas rebeldes de sus bases ocultas y los persiguen a través de la galaxia. Mientras, el grupo de rebeldes de Skywalker se esconde en un planeta helado.", Trailer = "https://youtu.be/Cgj0Pr6Ubqs" },
                    new Peliculas { PeliculaId = 3, Titulo = "Star Wars:Episodio VI El retorno del Jedi", Poster = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTXPU8__AsCs2FxSQ62Rn7I0OlCAFs_17nqY2sD_RGsMd2Y9uPF", Sinopsis = "Luke Skywalker, ahora un experimentado caballero Jedi, intenta descubrir la identidad de Darth Vader.", Trailer = "https://youtu.be/Q4xMJxTaToQ" },
                    new Peliculas { PeliculaId = 4, Titulo = "Star Wars:Episodio I La amenaza fantasma", Poster = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRcSp3BcESE4TrXR3eaghjYYNfPWCVRtc-ATyQGZD-RHeDUd-zF", Sinopsis = "Obi-Wan Kenobi es un joven aprendiz caballero Jedi bajo la tutela de Qui-Gon Jinn. Cuando la Federación de Comercio corta todas las rutas al planeta Naboo, Qui-Gon y Obi-Wan son asignados para solucionar el problema.", Trailer = "https://youtu.be/L9ZgGEkH-yU" },
                    new Peliculas { PeliculaId = 5, Titulo = "Star Wars:Episodio II El ataque de los clones", Poster = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQpbOR5bkTGz0c69DSqWJYmU_GSJS3uIS0FiUOJG8B7QPlQD0vZ", Sinopsis = "En el Senado Galáctico reina la inquietud. Varios miles de sistemas solares han declarado su intención de abandonar la República. La reina Amidala regresa al Senado para conseguir un ejército que ayude a los caballeros jedi.", Trailer = "https://youtu.be/KYcb9jSjcDc" },
                    new Peliculas { PeliculaId = 6, Titulo = "Star Wars:Episodio III La venganza de los sith", Poster = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcR2S6Cnnf2IyMWxxboeFEpd4M8S-fXQZ-bPPfgnUFRDe7O53uIw", Sinopsis = "Seducido por el lado oscuro, Anakin Skywalker se rebela contra su mentor, Obi-Wan Kenobi, y se convierte en Darth Vader.", Trailer = "https://youtu.be/d3XN49jmmGM" },
                    new Peliculas { PeliculaId = 7, Titulo = "Star Wars:Episodio VII El despertar de la fuerza", Poster = "https://static.wikia.nocookie.net/esstarwars/images/2/2e/El_Despertar_de_la_Fuerza_Poster.jpg/revision/latest?cb=20180412014438", Sinopsis = "El terrible y enigmático guerrero Kylo Ren ha reunido un nuevo ejército del Imperio, que se hace llamar la Primera Orden y ataca a la Alianza. La única esperanza para la galaxia es que Rey, Finn y BB-8 logren encontrar a tiempo a Luke Skywalker.", Trailer = "https://youtu.be/EPkdiNHfF1U" },
                    new Peliculas { PeliculaId = 8, Titulo = "Star Wars:Episodio VIII Los últimos Jedi", Poster = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQCwbhD-mFerQzUo94bQvkzyS8yCyg7H4_Q8zxHInQGNN7JV92A", Sinopsis = "La Primera Orden ha acorralado a los últimos miembros de la resistencia. Su última esperanza es que Finn se introduzca en la nave de Snoke y desactive el radar que les permite localizarlos. A su vez, Luke Skywalker se encuentra entrenando a Rey.", Trailer = "https://youtu.be/EFNcvyWD4Ag" },
                    new Peliculas { PeliculaId = 9, Titulo = "Star Wars:Episodio IX El ascenso de Skywalker", Poster = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcT5T11lO5NUu09B5i37f3QC6VQVRMs2kkTrcwnYV9A3y--NUgI5", Sinopsis = "Finn y Poe guían a la Resistencia para detener los planes de la Primera Orden para formar un nuevo imperio, mientras Rey anticipa un enfrentamiento inevitable con Kylo Ren.", Trailer = "https://youtu.be/o56ubcfwSzY" },
                    new Peliculas { PeliculaId = 10, Titulo = "Rogue One: una historia de Star Wars", Poster = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQ81FkPnEGE1MrMa3gm9_s644scRNJEMpKRvMgvBivM8qj3fGZ4", Sinopsis = "El Imperio va a construir una estación espacial capaz de destruir planetas, conocida como la Estrella de la Muerte. Los rebeldes, conocedores de esto, se embarcan en una misión extraordinaria: robar los planos y sabotear la estación.", Trailer = "https://youtu.be/D47iksCvnRw" }
                    );
        }
    }
}
