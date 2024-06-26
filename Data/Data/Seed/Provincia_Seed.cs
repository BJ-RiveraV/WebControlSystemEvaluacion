﻿using Data.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Data.Seed
{
    public class Provincia_Seed : IEntityTypeConfiguration<Provincia>
    {
        public void Configure(EntityTypeBuilder<Provincia> builder)
        {
            builder.HasData(
                new Provincia() { Id = 130, Nombre = "Chachapoyas", DepartamentoId = 1 },
                new Provincia() { Id = 131, Nombre = "Bagua", DepartamentoId = 1 },
                new Provincia() { Id = 132, Nombre = "Bongará", DepartamentoId = 1 },
                new Provincia() { Id = 133, Nombre = "Condorcanqui", DepartamentoId = 1 },
                new Provincia() { Id = 134, Nombre = "Luya", DepartamentoId = 1 },
                new Provincia() { Id = 135, Nombre = "Rodríguez de Mendoza", DepartamentoId = 1 },
                new Provincia() { Id = 136, Nombre = "Utcubamba", DepartamentoId = 1 },
                new Provincia() { Id = 137, Nombre = "Huaraz", DepartamentoId = 2 },
                new Provincia() { Id = 138, Nombre = "Aija", DepartamentoId = 2 },
                new Provincia() { Id = 139, Nombre = "Antonio Raymondi", DepartamentoId = 2 },
                new Provincia() { Id = 140, Nombre = "Asunción", DepartamentoId = 2 },
                new Provincia() { Id = 141, Nombre = "Bolognesi", DepartamentoId = 2 },
                new Provincia() { Id = 142, Nombre = "Carhuaz", DepartamentoId = 2 },
                new Provincia() { Id = 143, Nombre = "Carlos F", DepartamentoId = 2 },
                new Provincia() { Id = 144, Nombre = "Fitzcarrald", DepartamentoId = 2 },
                new Provincia() { Id = 145, Nombre = "Casma", DepartamentoId = 2 },
                new Provincia() { Id = 146, Nombre = "Corongo", DepartamentoId = 2 },
                new Provincia() { Id = 147, Nombre = "Huari", DepartamentoId = 2 },
                new Provincia() { Id = 148, Nombre = "Huarmey", DepartamentoId = 2 },
                new Provincia() { Id = 149, Nombre = "Huaylas", DepartamentoId = 2 },
                new Provincia() { Id = 150, Nombre = "Mariscal Luzuriaga", DepartamentoId = 2 },
                new Provincia() { Id = 151, Nombre = "Ocros", DepartamentoId = 2 },
                new Provincia() { Id = 152, Nombre = "Pallasca", DepartamentoId = 2 },
                new Provincia() { Id = 153, Nombre = "Pomabamba", DepartamentoId = 2 },
                new Provincia() { Id = 154, Nombre = "Recuay", DepartamentoId = 2 },
                new Provincia() { Id = 155, Nombre = "Santa", DepartamentoId = 2 },
                new Provincia() { Id = 156, Nombre = "Sihuas", DepartamentoId = 2 },
                new Provincia() { Id = 157, Nombre = "Yungay", DepartamentoId = 2 },
                new Provincia() { Id = 158, Nombre = "Abancay", DepartamentoId = 3 },
                new Provincia() { Id = 159, Nombre = "Antabamba", DepartamentoId = 3 },
                new Provincia() { Id = 160, Nombre = "Aymaraes", DepartamentoId = 3 },
                new Provincia() { Id = 161, Nombre = "Cotabambas", DepartamentoId = 3 },
                new Provincia() { Id = 162, Nombre = "Grau", DepartamentoId = 3 },
                new Provincia() { Id = 163, Nombre = "Chincheros", DepartamentoId = 3 },
                new Provincia() { Id = 164, Nombre = "Andahuaylas", DepartamentoId = 3 },
                new Provincia() { Id = 165, Nombre = "Arequipa", DepartamentoId = 4 },
                new Provincia() { Id = 166, Nombre = "Camaná", DepartamentoId = 4 },
                new Provincia() { Id = 167, Nombre = "Caravelí", DepartamentoId = 4 },
                new Provincia() { Id = 168, Nombre = "Castilla", DepartamentoId = 4 },
                new Provincia() { Id = 169, Nombre = "Caylloma", DepartamentoId = 4 },
                new Provincia() { Id = 170, Nombre = "Condesuyos", DepartamentoId = 4 },
                new Provincia() { Id = 171, Nombre = "Islay", DepartamentoId = 4 },
                new Provincia() { Id = 172, Nombre = "La Unión", DepartamentoId = 4 },
                new Provincia() { Id = 1, Nombre = "Cangallo", DepartamentoId = 5 },
                new Provincia() { Id = 2, Nombre = "Huanta", DepartamentoId = 5 },
                new Provincia() { Id = 3, Nombre = "Huamanga", DepartamentoId = 5 },
                new Provincia() { Id = 4, Nombre = "Huanca Sancos", DepartamentoId = 5 },
                new Provincia() { Id = 5, Nombre = "La Mar", DepartamentoId = 5 },
                new Provincia() { Id = 6, Nombre = "Lucanas", DepartamentoId = 5 },
                new Provincia() { Id = 7, Nombre = "Parinacochas", DepartamentoId = 5 },
                new Provincia() { Id = 8, Nombre = "Páucar del Sara Sara", DepartamentoId = 5 },
                new Provincia() { Id = 9, Nombre = "Sucre", DepartamentoId = 5 },
                new Provincia() { Id = 10, Nombre = "Víctor Fajardo", DepartamentoId = 5 },
                new Provincia() { Id = 11, Nombre = "Vilcashuamán", DepartamentoId = 5 },
                new Provincia() { Id = 12, Nombre = "Cajamarca", DepartamentoId = 6 },
                new Provincia() { Id = 13, Nombre = "Cajabamba", DepartamentoId = 6 },
                new Provincia() { Id = 14, Nombre = "Celendín", DepartamentoId = 6 },
                new Provincia() { Id = 15, Nombre = "Chota", DepartamentoId = 6 },
                new Provincia() { Id = 16, Nombre = "Contumazá", DepartamentoId = 6 },
                new Provincia() { Id = 17, Nombre = "Cutervo", DepartamentoId = 6 },
                new Provincia() { Id = 18, Nombre = "Hualgayoc", DepartamentoId = 6 },
                new Provincia() { Id = 19, Nombre = "Jaén", DepartamentoId = 6 },
                new Provincia() { Id = 20, Nombre = "San Ignacio", DepartamentoId = 6 },
                new Provincia() { Id = 21, Nombre = "San Marcos", DepartamentoId = 6 },
                new Provincia() { Id = 22, Nombre = "San Miguel", DepartamentoId = 6 },
                new Provincia() { Id = 23, Nombre = "San Pablo", DepartamentoId = 6 },
                new Provincia() { Id = 24, Nombre = "Santa Cruz", DepartamentoId = 6 },
                new Provincia() { Id = 25, Nombre = "Callao", DepartamentoId = 7 },
                new Provincia() { Id = 26, Nombre = "Cuzco", DepartamentoId = 8 },
                new Provincia() { Id = 27, Nombre = "Acomayo", DepartamentoId = 8 },
                new Provincia() { Id = 28, Nombre = "Anta", DepartamentoId = 8 },
                new Provincia() { Id = 29, Nombre = "Calca", DepartamentoId = 8 },
                new Provincia() { Id = 30, Nombre = "Canas", DepartamentoId = 8 },
                new Provincia() { Id = 31, Nombre = "Canchis", DepartamentoId = 8 },
                new Provincia() { Id = 32, Nombre = "Chumbivilcas", DepartamentoId = 8 },
                new Provincia() { Id = 33, Nombre = "Espinar", DepartamentoId = 8 },
                new Provincia() { Id = 34, Nombre = "La Convención", DepartamentoId = 8 },
                new Provincia() { Id = 35, Nombre = "Paruro", DepartamentoId = 8 },
                new Provincia() { Id = 36, Nombre = "Paucartambo", DepartamentoId = 8 },
                new Provincia() { Id = 37, Nombre = "Quispicanchi", DepartamentoId = 8 },
                new Provincia() { Id = 38, Nombre = "Urubamba", DepartamentoId = 8 },
                new Provincia() { Id = 39, Nombre = "Huancavelica", DepartamentoId = 9 },
                new Provincia() { Id = 40, Nombre = "Acobamba", DepartamentoId = 9 },
                new Provincia() { Id = 41, Nombre = "Angaraes", DepartamentoId = 9 },
                new Provincia() { Id = 42, Nombre = "Castrovirreyna", DepartamentoId = 9 },
                new Provincia() { Id = 43, Nombre = "Churcampa", DepartamentoId = 9 },
                new Provincia() { Id = 44, Nombre = "Huaytará", DepartamentoId = 9 },
                new Provincia() { Id = 45, Nombre = "Tayacaja", DepartamentoId = 9 },
                new Provincia() { Id = 46, Nombre = "Huánuco", DepartamentoId = 10 },
                new Provincia() { Id = 47, Nombre = "Ambo", DepartamentoId = 10 },
                new Provincia() { Id = 48, Nombre = "Dos de Mayo", DepartamentoId = 10 },
                new Provincia() { Id = 49, Nombre = "Huacaybamba", DepartamentoId = 10 },
                new Provincia() { Id = 50, Nombre = "Huamalíes", DepartamentoId = 10 },
                new Provincia() { Id = 51, Nombre = "Leoncio Prado", DepartamentoId = 10 },
                new Provincia() { Id = 52, Nombre = "Marañón", DepartamentoId = 10 },
                new Provincia() { Id = 53, Nombre = "Pachitea", DepartamentoId = 10 },
                new Provincia() { Id = 54, Nombre = "Puerto Inca", DepartamentoId = 10 },
                new Provincia() { Id = 55, Nombre = "Lauricocha", DepartamentoId = 10 },
                new Provincia() { Id = 56, Nombre = "Yarowilca", DepartamentoId = 10 },
                new Provincia() { Id = 57, Nombre = "Ica", DepartamentoId = 11 },
                new Provincia() { Id = 58, Nombre = "Chincha", DepartamentoId = 11 },
                new Provincia() { Id = 59, Nombre = "Nazca", DepartamentoId = 11 },
                new Provincia() { Id = 60, Nombre = "Palpa", DepartamentoId = 11 },
                new Provincia() { Id = 61, Nombre = "Pisco", DepartamentoId = 11 },
                new Provincia() { Id = 62, Nombre = "Chanchamayo", DepartamentoId = 12 },
                new Provincia() { Id = 63, Nombre = "Chupaca", DepartamentoId = 12 },
                new Provincia() { Id = 64, Nombre = "Concepción", DepartamentoId = 12 },
                new Provincia() { Id = 65, Nombre = "Huancayo", DepartamentoId = 12 },
                new Provincia() { Id = 66, Nombre = "Jauja", DepartamentoId = 12 },
                new Provincia() { Id = 67, Nombre = "Junín", DepartamentoId = 12 },
                new Provincia() { Id = 68, Nombre = "Satipo", DepartamentoId = 12 },
                new Provincia() { Id = 69, Nombre = "Tarma", DepartamentoId = 12 },
                new Provincia() { Id = 70, Nombre = "Yauli", DepartamentoId = 12 },
                new Provincia() { Id = 71, Nombre = "Trujillo", DepartamentoId = 13 },
                new Provincia() { Id = 72, Nombre = "Ascope", DepartamentoId = 13 },
                new Provincia() { Id = 73, Nombre = "Bolívar", DepartamentoId = 13 },
                new Provincia() { Id = 74, Nombre = "Chepén", DepartamentoId = 13 },
                new Provincia() { Id = 75, Nombre = "Julcán", DepartamentoId = 13 },
                new Provincia() { Id = 76, Nombre = "Otuzco", DepartamentoId = 13 },
                new Provincia() { Id = 77, Nombre = "Gran Chimú", DepartamentoId = 13 },
                new Provincia() { Id = 78, Nombre = "Pacasmayo", DepartamentoId = 13 },
                new Provincia() { Id = 79, Nombre = "Pataz", DepartamentoId = 13 },
                new Provincia() { Id = 80, Nombre = "Sánchez Carrión", DepartamentoId = 13 },
                new Provincia() { Id = 81, Nombre = "Santiago de Chuco", DepartamentoId = 13 },
                new Provincia() { Id = 82, Nombre = "Virú", DepartamentoId = 13 },
                new Provincia() { Id = 83, Nombre = "Chiclayo", DepartamentoId = 14 },
                new Provincia() { Id = 84, Nombre = "Ferreñafe", DepartamentoId = 14 },
                new Provincia() { Id = 85, Nombre = "Lambayeque", DepartamentoId = 14 },
                new Provincia() { Id = 86, Nombre = "Barranca", DepartamentoId = 15 },
                new Provincia() { Id = 87, Nombre = "Cajatambo", DepartamentoId = 15 },
                new Provincia() { Id = 88, Nombre = "Canta", DepartamentoId = 15 },
                new Provincia() { Id = 89, Nombre = "Cañete", DepartamentoId = 15 },
                new Provincia() { Id = 90, Nombre = "Huaral", DepartamentoId = 15 },
                new Provincia() { Id = 91, Nombre = "Huarochirí", DepartamentoId = 15 },
                new Provincia() { Id = 92, Nombre = "Huaura", DepartamentoId = 15 },
                new Provincia() { Id = 93, Nombre = "Lima", DepartamentoId = 15 },
                new Provincia() { Id = 94, Nombre = "Oyón", DepartamentoId = 15 },
                new Provincia() { Id = 95, Nombre = "Yauyos", DepartamentoId = 15 },
                new Provincia() { Id = 96, Nombre = "Maynas", DepartamentoId = 16 },
                new Provincia() { Id = 97, Nombre = "Putumayo", DepartamentoId = 16 },
                new Provincia() { Id = 98, Nombre = "Alto Amazonas", DepartamentoId = 16 },
                new Provincia() { Id = 99, Nombre = "Loreto", DepartamentoId = 16 },
                new Provincia() { Id = 100, Nombre = "Mariscal Ramón Castilla", DepartamentoId = 16 },
                new Provincia() { Id = 101, Nombre = "Requena", DepartamentoId = 16 },
                new Provincia() { Id = 102, Nombre = "Ucayali", DepartamentoId = 16 },
                new Provincia() { Id = 103, Nombre = "Datem del Marañón", DepartamentoId = 16 },
                new Provincia() { Id = 104, Nombre = "Tambopata", DepartamentoId = 17 },
                new Provincia() { Id = 105, Nombre = "Manu", DepartamentoId = 17 },
                new Provincia() { Id = 106, Nombre = "Tahuamanu", DepartamentoId = 17 },
                new Provincia() { Id = 107, Nombre = "Mariscal Nieto", DepartamentoId = 18 },
                new Provincia() { Id = 108, Nombre = "General Sánchez Cerro", DepartamentoId = 18 },
                new Provincia() { Id = 109, Nombre = "Ilo", DepartamentoId = 18 },
                new Provincia() { Id = 110, Nombre = "Pasco", DepartamentoId = 19 },
                new Provincia() { Id = 111, Nombre = "Oxapampa", DepartamentoId = 19 },
                new Provincia() { Id = 112, Nombre = "Daniel A", DepartamentoId = 19 },
                new Provincia() { Id = 113, Nombre = "Carrión", DepartamentoId = 19 },
                new Provincia() { Id = 114, Nombre = "Ayabaca", DepartamentoId = 20 },
                new Provincia() { Id = 115, Nombre = "Huancabamba", DepartamentoId = 20 },
                new Provincia() { Id = 116, Nombre = "Morropón", DepartamentoId = 20 },
                new Provincia() { Id = 117, Nombre = "Piura", DepartamentoId = 20 },
                new Provincia() { Id = 118, Nombre = "Sechura", DepartamentoId = 20 },
                new Provincia() { Id = 119, Nombre = "Sullana", DepartamentoId = 20 },
                new Provincia() { Id = 120, Nombre = "Paita", DepartamentoId = 20 },
                new Provincia() { Id = 121, Nombre = "Talara", DepartamentoId = 20 },
                new Provincia() { Id = 122, Nombre = "San Román", DepartamentoId = 21 },
                new Provincia() { Id = 123, Nombre = "Puno", DepartamentoId = 21 },
                new Provincia() { Id = 124, Nombre = "Azángaro", DepartamentoId = 21 },
                new Provincia() { Id = 125, Nombre = "Chucuito", DepartamentoId = 21 },
                new Provincia() { Id = 126, Nombre = "El Collao", DepartamentoId = 21 },
                new Provincia() { Id = 127, Nombre = "Melgar", DepartamentoId = 21 },
                new Provincia() { Id = 128, Nombre = "Carabaya", DepartamentoId = 21 },
                new Provincia() { Id = 129, Nombre = "Huancané", DepartamentoId = 21 }
                );
        }
    }
}
