using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.AspNetCore.Authorization;

using ProyectoG60.App.Dominio;
using ProyectoG60.App.Persistencia;

namespace ProyectoG60.App.Presentacion.Pages
{
    //[Authorize]
    public class ListModel : PageModel
    {
        private readonly IRepositorioFormador repositorioFormadores;

        public IEnumerable<Formador> formadores { get; set; }

        public ListModel(){
            this.repositorioFormadores=new RepositorioFormador(new ProyectoG60.App.Persistencia.AppContext());
            //simular la lista a mostrar en la tabla HTML
            /*formadores = new List<Formador>()
            {
                new Formador{id=1, identificacion="102030", nombre="Jhon Jairo Orozco"},
                new Formador{id=2, identificacion="304050", nombre="Luz Dary Martinez"},
                new Formador{id=3, identificacion="607080", nombre="Mateo Orozco"}
            };  */
        }

        public void OnGet()
        {
            formadores = repositorioFormadores.GetAllFormadores();

        }
    }
}

