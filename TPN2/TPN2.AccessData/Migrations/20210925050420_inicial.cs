using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TPN2.AccessData.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    PeliculaId = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Poster = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Sinopsis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.PeliculaId);
                });

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    SalaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacidad = table.Column<int>(type: "int", maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.SalaId);
                });

            migrationBuilder.CreateTable(
                name: "Funciones",
                columns: table => new
                {
                    FuncionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeliculaId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    SalaId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horario = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funciones", x => x.FuncionId);
                    table.ForeignKey(
                        name: "FK_Funciones_Peliculas_PeliculaId",
                        column: x => x.PeliculaId,
                        principalTable: "Peliculas",
                        principalColumn: "PeliculaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funciones_Salas_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Salas",
                        principalColumn: "SalaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FuncionId = table.Column<int>(type: "int", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => new { x.TicketId, x.FuncionId });
                    table.ForeignKey(
                        name: "FK_Tickets_Funciones_FuncionId",
                        column: x => x.FuncionId,
                        principalTable: "Funciones",
                        principalColumn: "FuncionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "PeliculaId", "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[,]
                {
                    { 1, "https://es.web.img3.acsta.net/c_310_420/medias/nmedia/18/71/18/12/20061511.jpg", "Leia es capturada por las tropas imperiales, antes de ser atrapada logra colocar el mensaje en R2D2. Al llegar a Tattooine junto con C3PO son capturados y vendidos al joven Luke Skywalker, quien descubrirá el mensaje oculto para salvar a Leia.", "Star Wars:Episodio IV Una nueva esperanza", "https://youtu.be/_sQSHZ65fPI" },
                    { 2, "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTAFLmt-Hfy6valTAd6sdWx0GcUYd-qS_Bkd4-Tk7_pGOa7DLEd", "Aunque la Estrella de la Muerte ha sido destruida, las tropas imperiales han hecho salir a las fuerzas rebeldes de sus bases ocultas y los persiguen a través de la galaxia. Mientras, el grupo de rebeldes de Skywalker se esconde en un planeta helado.", "Star Wars:Episodio V El imperio contraataca", "https://youtu.be/Cgj0Pr6Ubqs" },
                    { 3, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTXPU8__AsCs2FxSQ62Rn7I0OlCAFs_17nqY2sD_RGsMd2Y9uPF", "Luke Skywalker, ahora un experimentado caballero Jedi, intenta descubrir la identidad de Darth Vader.", "Star Wars:Episodio VI El retorno del Jedi", "https://youtu.be/Q4xMJxTaToQ" },
                    { 4, "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRcSp3BcESE4TrXR3eaghjYYNfPWCVRtc-ATyQGZD-RHeDUd-zF", "Obi-Wan Kenobi es un joven aprendiz caballero Jedi bajo la tutela de Qui-Gon Jinn. Cuando la Federación de Comercio corta todas las rutas al planeta Naboo, Qui-Gon y Obi-Wan son asignados para solucionar el problema.", "Star Wars:Episodio I La amenaza fantasma", "https://youtu.be/L9ZgGEkH-yU" },
                    { 5, "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQpbOR5bkTGz0c69DSqWJYmU_GSJS3uIS0FiUOJG8B7QPlQD0vZ", "En el Senado Galáctico reina la inquietud. Varios miles de sistemas solares han declarado su intención de abandonar la República. La reina Amidala regresa al Senado para conseguir un ejército que ayude a los caballeros jedi.", "Star Wars:Episodio II El ataque de los clones", "https://youtu.be/KYcb9jSjcDc" },
                    { 6, "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcR2S6Cnnf2IyMWxxboeFEpd4M8S-fXQZ-bPPfgnUFRDe7O53uIw", "Seducido por el lado oscuro, Anakin Skywalker se rebela contra su mentor, Obi-Wan Kenobi, y se convierte en Darth Vader.", "Star Wars:Episodio III La venganza de los sith", "https://youtu.be/d3XN49jmmGM" },
                    { 7, "https://static.wikia.nocookie.net/esstarwars/images/2/2e/El_Despertar_de_la_Fuerza_Poster.jpg/revision/latest?cb=20180412014438", "El terrible y enigmático guerrero Kylo Ren ha reunido un nuevo ejército del Imperio, que se hace llamar la Primera Orden y ataca a la Alianza. La única esperanza para la galaxia es que Rey, Finn y BB-8 logren encontrar a tiempo a Luke Skywalker.", "Star Wars:Episodio VII El despertar de la fuerza", "https://youtu.be/EPkdiNHfF1U" },
                    { 8, "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQCwbhD-mFerQzUo94bQvkzyS8yCyg7H4_Q8zxHInQGNN7JV92A", "La Primera Orden ha acorralado a los últimos miembros de la resistencia. Su última esperanza es que Finn se introduzca en la nave de Snoke y desactive el radar que les permite localizarlos. A su vez, Luke Skywalker se encuentra entrenando a Rey.", "Star Wars:Episodio VIII Los últimos Jedi", "https://youtu.be/EFNcvyWD4Ag" },
                    { 9, "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcT5T11lO5NUu09B5i37f3QC6VQVRMs2kkTrcwnYV9A3y--NUgI5", "Finn y Poe guían a la Resistencia para detener los planes de la Primera Orden para formar un nuevo imperio, mientras Rey anticipa un enfrentamiento inevitable con Kylo Ren.", "Star Wars:Episodio IX El ascenso de Skywalker", "https://youtu.be/o56ubcfwSzY" },
                    { 10, "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQ81FkPnEGE1MrMa3gm9_s644scRNJEMpKRvMgvBivM8qj3fGZ4", "El Imperio va a construir una estación espacial capaz de destruir planetas, conocida como la Estrella de la Muerte. Los rebeldes, conocedores de esto, se embarcan en una misión extraordinaria: robar los planos y sabotear la estación.", "Rogue One: una historia de Star Wars", "https://youtu.be/D47iksCvnRw" }
                });

            migrationBuilder.InsertData(
                table: "Salas",
                columns: new[] { "SalaId", "Capacidad" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 2, 15 },
                    { 3, 35 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funciones_PeliculaId",
                table: "Funciones",
                column: "PeliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Funciones_SalaId",
                table: "Funciones",
                column: "SalaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_FuncionId",
                table: "Tickets",
                column: "FuncionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Funciones");

            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Salas");
        }
    }
}
