using System;

namespace ProyectoG59.App.Dominio.Entidades
{
    public class Tarea
    {
        //atributos de la tabla o clase; pasa a llamarsen propiedades
        public int id{ get; set;}
        public string codigo{ get; set; }
        public string nombre{ get; set; }
        public int puntos{ get; set; }
        //foraneas o relaciones
        public int equipo { get; set;} 
        public int estudiante { get; set;}        
        public int sprint { get; set;}         
        public int estadoProyecto { get; set; }
    }
}