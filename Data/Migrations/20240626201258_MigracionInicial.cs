using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provincias_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroDocumento = table.Column<long>(type: "bigint", nullable: false),
                    ProvinciaId = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Sexo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Provincias_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Amazonas" },
                    { 2, "Ancash" },
                    { 3, "Apurímac" },
                    { 4, "Arequipa" },
                    { 5, "Ayacucho" },
                    { 6, "Cajamarca" },
                    { 7, "Callao" },
                    { 8, "Cusco" },
                    { 9, "Huancavelica" },
                    { 10, "Huánuco" },
                    { 11, "Ica" },
                    { 12, "Junín" },
                    { 13, "La Libertad" },
                    { 14, "Lambayeque" },
                    { 15, "Lima" },
                    { 16, "Loreto" },
                    { 17, "Madre de Dios" },
                    { 18, "Moquegua" },
                    { 19, "Pasco" },
                    { 20, "Piura" },
                    { 21, "Puno" }
                });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "Id", "DepartamentoId", "Nombre" },
                values: new object[,]
                {
                    { 1, 5, "Cangallo" },
                    { 2, 5, "Huanta" },
                    { 3, 5, "Huamanga" },
                    { 4, 5, "Huanca Sancos" },
                    { 5, 5, "La Mar" },
                    { 6, 5, "Lucanas" },
                    { 7, 5, "Parinacochas" },
                    { 8, 5, "Páucar del Sara Sara" },
                    { 9, 5, "Sucre" },
                    { 10, 5, "Víctor Fajardo" },
                    { 11, 5, "Vilcashuamán" },
                    { 12, 6, "Cajamarca" },
                    { 13, 6, "Cajabamba" },
                    { 14, 6, "Celendín" },
                    { 15, 6, "Chota" },
                    { 16, 6, "Contumazá" },
                    { 17, 6, "Cutervo" },
                    { 18, 6, "Hualgayoc" },
                    { 19, 6, "Jaén" },
                    { 20, 6, "San Ignacio" },
                    { 21, 6, "San Marcos" },
                    { 22, 6, "San Miguel" },
                    { 23, 6, "San Pablo" },
                    { 24, 6, "Santa Cruz" },
                    { 25, 7, "Callao" },
                    { 26, 8, "Cuzco" },
                    { 27, 8, "Acomayo" },
                    { 28, 8, "Anta" },
                    { 29, 8, "Calca" },
                    { 30, 8, "Canas" },
                    { 31, 8, "Canchis" },
                    { 32, 8, "Chumbivilcas" },
                    { 33, 8, "Espinar" },
                    { 34, 8, "La Convención" },
                    { 35, 8, "Paruro" },
                    { 36, 8, "Paucartambo" },
                    { 37, 8, "Quispicanchi" },
                    { 38, 8, "Urubamba" },
                    { 39, 9, "Huancavelica" },
                    { 40, 9, "Acobamba" },
                    { 41, 9, "Angaraes" },
                    { 42, 9, "Castrovirreyna" }
                });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "Id", "DepartamentoId", "Nombre" },
                values: new object[,]
                {
                    { 43, 9, "Churcampa" },
                    { 44, 9, "Huaytará" },
                    { 45, 9, "Tayacaja" },
                    { 46, 10, "Huánuco" },
                    { 47, 10, "Ambo" },
                    { 48, 10, "Dos de Mayo" },
                    { 49, 10, "Huacaybamba" },
                    { 50, 10, "Huamalíes" },
                    { 51, 10, "Leoncio Prado" },
                    { 52, 10, "Marañón" },
                    { 53, 10, "Pachitea" },
                    { 54, 10, "Puerto Inca" },
                    { 55, 10, "Lauricocha" },
                    { 56, 10, "Yarowilca" },
                    { 57, 11, "Ica" },
                    { 58, 11, "Chincha" },
                    { 59, 11, "Nazca" },
                    { 60, 11, "Palpa" },
                    { 61, 11, "Pisco" },
                    { 62, 12, "Chanchamayo" },
                    { 63, 12, "Chupaca" },
                    { 64, 12, "Concepción" },
                    { 65, 12, "Huancayo" },
                    { 66, 12, "Jauja" },
                    { 67, 12, "Junín" },
                    { 68, 12, "Satipo" },
                    { 69, 12, "Tarma" },
                    { 70, 12, "Yauli" },
                    { 71, 13, "Trujillo" },
                    { 72, 13, "Ascope" },
                    { 73, 13, "Bolívar" },
                    { 74, 13, "Chepén" },
                    { 75, 13, "Julcán" },
                    { 76, 13, "Otuzco" },
                    { 77, 13, "Gran Chimú" },
                    { 78, 13, "Pacasmayo" },
                    { 79, 13, "Pataz" },
                    { 80, 13, "Sánchez Carrión" },
                    { 81, 13, "Santiago de Chuco" },
                    { 82, 13, "Virú" },
                    { 83, 14, "Chiclayo" },
                    { 84, 14, "Ferreñafe" }
                });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "Id", "DepartamentoId", "Nombre" },
                values: new object[,]
                {
                    { 85, 14, "Lambayeque" },
                    { 86, 15, "Barranca" },
                    { 87, 15, "Cajatambo" },
                    { 88, 15, "Canta" },
                    { 89, 15, "Cañete" },
                    { 90, 15, "Huaral" },
                    { 91, 15, "Huarochirí" },
                    { 92, 15, "Huaura" },
                    { 93, 15, "Lima" },
                    { 94, 15, "Oyón" },
                    { 95, 15, "Yauyos" },
                    { 96, 16, "Maynas" },
                    { 97, 16, "Putumayo" },
                    { 98, 16, "Alto Amazonas" },
                    { 99, 16, "Loreto" },
                    { 100, 16, "Mariscal Ramón Castilla" },
                    { 101, 16, "Requena" },
                    { 102, 16, "Ucayali" },
                    { 103, 16, "Datem del Marañón" },
                    { 104, 17, "Tambopata" },
                    { 105, 17, "Manu" },
                    { 106, 17, "Tahuamanu" },
                    { 107, 18, "Mariscal Nieto" },
                    { 108, 18, "General Sánchez Cerro" },
                    { 109, 18, "Ilo" },
                    { 110, 19, "Pasco" },
                    { 111, 19, "Oxapampa" },
                    { 112, 19, "Daniel A" },
                    { 113, 19, "Carrión" },
                    { 114, 20, "Ayabaca" },
                    { 115, 20, "Huancabamba" },
                    { 116, 20, "Morropón" },
                    { 117, 20, "Piura" },
                    { 118, 20, "Sechura" },
                    { 119, 20, "Sullana" },
                    { 120, 20, "Paita" },
                    { 121, 20, "Talara" },
                    { 122, 21, "San Román" },
                    { 123, 21, "Puno" },
                    { 124, 21, "Azángaro" },
                    { 125, 21, "Chucuito" },
                    { 126, 21, "El Collao" }
                });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "Id", "DepartamentoId", "Nombre" },
                values: new object[,]
                {
                    { 127, 21, "Melgar" },
                    { 128, 21, "Carabaya" },
                    { 129, 21, "Huancané" },
                    { 130, 1, "Chachapoyas" },
                    { 131, 1, "Bagua" },
                    { 132, 1, "Bongará" },
                    { 133, 1, "Condorcanqui" },
                    { 134, 1, "Luya" },
                    { 135, 1, "Rodríguez de Mendoza" },
                    { 136, 1, "Utcubamba" },
                    { 137, 2, "Huaraz" },
                    { 138, 2, "Aija" },
                    { 139, 2, "Antonio Raymondi" },
                    { 140, 2, "Asunción" },
                    { 141, 2, "Bolognesi" },
                    { 142, 2, "Carhuaz" },
                    { 143, 2, "Carlos F" },
                    { 144, 2, "Fitzcarrald" },
                    { 145, 2, "Casma" },
                    { 146, 2, "Corongo" },
                    { 147, 2, "Huari" },
                    { 148, 2, "Huarmey" },
                    { 149, 2, "Huaylas" },
                    { 150, 2, "Mariscal Luzuriaga" },
                    { 151, 2, "Ocros" },
                    { 152, 2, "Pallasca" },
                    { 153, 2, "Pomabamba" },
                    { 154, 2, "Recuay" },
                    { 155, 2, "Santa" },
                    { 156, 2, "Sihuas" },
                    { 157, 2, "Yungay" },
                    { 158, 3, "Abancay" },
                    { 159, 3, "Antabamba" },
                    { 160, 3, "Aymaraes" },
                    { 161, 3, "Cotabambas" },
                    { 162, 3, "Grau" },
                    { 163, 3, "Chincheros" },
                    { 164, 3, "Andahuaylas" },
                    { 165, 4, "Arequipa" },
                    { 166, 4, "Camaná" },
                    { 167, 4, "Caravelí" },
                    { 168, 4, "Castilla" }
                });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "Id", "DepartamentoId", "Nombre" },
                values: new object[,]
                {
                    { 169, 4, "Caylloma" },
                    { 170, 4, "Condesuyos" },
                    { 171, 4, "Islay" },
                    { 172, 4, "La Unión" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Provincias_DepartamentoId",
                table: "Provincias",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Correo",
                table: "Users",
                column: "Correo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_NumeroDocumento",
                table: "Users",
                column: "NumeroDocumento",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProvinciaId",
                table: "Users",
                column: "ProvinciaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Provincias");

            migrationBuilder.DropTable(
                name: "Departamentos");
        }
    }
}
