using EntregaRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntregaRazor.Pages
{
    public class filterModel : PageModel
    {
        [BindProperty]
        public string RanuraSelected { get; set; }
        public string TypeSelected { get; set; }

        public readonly WarframeDB datos;
        public filterModel(WarframeDB datos)
        {
            this.datos = datos;
        }
        public IActionResult OnGet()
        {
            string ranura = RanuraSelected;
            return Page();
        }
        public IActionResult OnPost()
        {
            string ranura = RanuraSelected;
            string type = TypeSelected;
            return Page();
        }
    }

}
