using Microsoft.EntityFrameworkCore;
using EntregaRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntregaRazor.Pages
{
    public class datesModel : PageModel
    {
        [BindProperty]
        public DateTime? Fecha { get; set; }

        public readonly WarframeDB datos;
        public datesModel(WarframeDB datos)
        {
            this.datos = datos;
        }
        public IActionResult OnGet()
        {
            DateTime? fecha = this.Fecha;
            return Page();
        }
    }
}
