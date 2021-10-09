using System;

using ProyectoG60.App.Dominio;
using ProyectoG60.App.Persistencia;

namespace ProyectoG60.App.Consola
{
    class Program
    {
        private static IRepositorioFormador _repoFormador = new RepositorioFormador (new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("PROBANDO INSERTAR DBCONTEXT-BD");
            AddFormador();

        }

        private static void AddFormador(){
            //CREAR manuelmente un fordor
            var formador = new Formador
            {               
                identificacion = "102030",
                nombre = "probando adicionar"
            };

            _repoFormador.AddFormador(formador);
        }
    }
}
