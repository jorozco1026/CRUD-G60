using System;

namespace ProyectoG59.App.Dominio.Entidades
{
    public class EquipoEstudiante
    {
        //atributos de la tabla o clase; pasa a llamarsen propiedades
        public int id { get; set; }
        public float nota1 { get; set; }
        public float nota2 { get; set; }
        public float nota3 { get; set; }
        public float nota4 { get; set; }
        public float nota5 { get; set; }

        //foraneas o relaciones
        public int equipo { get; set;}
        public int estudiante { get; set;}        
        public int rol { get; set; }
    }
}