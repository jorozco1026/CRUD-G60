using System;

namespace ProyectoG59.App.Dominio.Entidades
{
    public class Sprint
    {
        //atributos de la tabla o clase; pasa a llamarsen propiedades
        public int id{ get; set;}
        public string codigo{ get; set; }
        public string nombre{ get; set; }
        public int puntos{ get; set; }
        public DateTime fechaInicio{ get; set; }
        public DateTime fechaFinal{ get; set; }
        public DateTime fechaRevision{ get; set; }
        //foraneas o relaciones
        public int proyecto { get; set;} 
    }
}