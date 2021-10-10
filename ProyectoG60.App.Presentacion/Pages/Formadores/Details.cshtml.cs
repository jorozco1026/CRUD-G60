using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ProyectoG60.App.Dominio;
using ProyectoG60.App.Persistencia;


namespace ProyectoG60.App.Presentacion.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioFormador repositorioFormadores;
        public Formador formador { get; set; }

        public DetailsModel(IRepositorioFormador repositorioFormadores)
        {            
            this.repositorioFormadores=new RepositorioFormador(new ProyectoG60.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int formadorId)
        {
            formador = repositorioFormadores.GetFormador(formadorId);
            if(formador==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}