﻿namespace Data.Modelos
{
    public class Departamento
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public List<Provincia> Provincias { get; set; } = new List<Provincia>();
    }
}
