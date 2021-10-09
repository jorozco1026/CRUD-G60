//Directivas
using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoG60.App.Dominio.Entidades;

namespace ProyectoG60.App.Persistencia.AppRepositorios
{
    public interface IRepositorioFormador
    {
        //contratos o firmas para los metodos Formador        
        Formador AddFormador(Formador formador);
        IEnumerable<Formador> GetAllFormadores();         
        Formador GetFormador(int idFormador);
        Formador UpdateFormador(Formador formador);
        void DeleteFormador(int idFormador); 
    }
}