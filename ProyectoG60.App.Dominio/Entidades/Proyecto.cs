using System;

namespace ProyectoG59.App.Dominio.Entidades
{
    public class Proyecto
    {
        //atributos de la tabla o clase; pasa a llamarsen propiedades
        public int id{ get; set;}
        public string codigo{ get; set; }
        public string nombre{ get; set; }
        public string tema{ get; set; }
        public DateTime fechaInicio{ get; set; }
        public DateTime fechaFinal{ get; set; }
        //foraneas o relaciones
        public int equipo { get; set;}        
        public int estadoProyecto { get; set; }
    }
}