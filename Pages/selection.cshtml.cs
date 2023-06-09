using Microsoft.EntityFrameworkCore;
using EntregaRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EntregaRazor.Pages
{
    public class selectionModel : PageModel
    {
        [BindProperty]
        public bool Frio { get; set; }
        [BindProperty]
        public bool Calor { get; set; }
        [BindProperty]
        public bool Electrico { get; set; }
        [BindProperty]
        public bool Toxina { get; set; }

        public readonly WarframeDB datos;
        public selectionModel(WarframeDB datos)
        {
            this.datos = datos;
        }
        public IActionResult OnPost()
        {
            var frio = Frio;
            var calor = Calor;
            var electrico = Electrico;
            var toxina = Toxina;
            return Page();
        }
        
    }
}