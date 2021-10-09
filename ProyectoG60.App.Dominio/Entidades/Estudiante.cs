using System;

namespace ProyectoG59.App.Dominio.Entidades
{
    public class Estudiante
    {
        public int id { get; set; }
        public string identificacion { get; set; }
        public string nombre { get; set; }
        public string mail { get; set; }
        public string movil { get; set; }
    }
}