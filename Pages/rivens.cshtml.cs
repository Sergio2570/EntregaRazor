//using EntregaRazor.Data;
//using EntregaRazor.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.EntityFrameworkCore;
//using System.Data.Common;

//namespace EntregaRazor.Pages
//{
//    public class rivensModel : PageModel
//    {
//        [BindProperty]
//        public string Nombre { get; set; }
//        [BindProperty]
//        public string Arma { get; set; }
//        [BindProperty]
//        public string Buff1 { get; set; }
//        [BindProperty]
//        public decimal Valor1 { get; set; }
//        [BindProperty]
//        public string? Buff2 { get; set; }
//        [BindProperty]
//        public decimal? Valor2 { get; set; }
//        [BindProperty]
//        public string? Buff3 { get; set; }
//        [BindProperty]
//        public decimal? Valor3 { get; set; }
//        [BindProperty]
//        public string? DeBuff { get; set; }
//        [BindProperty]
//        public decimal? ValorDebuff { get; set; }
//        [BindProperty]
//        public string Propietario { get; set; }

//        public IActionResult OnPost()
//        {
//            Nombre = Nombre.Trim();
//            Arma = Arma.Trim();
//            Buff1 = Buff1.Trim();
//            Buff2 = Buff2.Trim();
//            Buff3 = Buff3.Trim();
//            Valor1 = Valor1;
//            Valor2 = Valor2;
//            Valor3 = Valor3;
//            DeBuff = DeBuff.Trim();
//            ValorDebuff = ValorDebuff;
//            Propietario = Propietario.Trim();
//            Agrietados newAgrietado = new(Nombre, Arma, Buff1, Valor1, Buff2, Valor2, Buff3, Valor3, DeBuff, ValorDebuff, Propietario);
//            Insert(newAgrietado);
//            return Page();
//        }

//        /*-----------------------------------------*/
//        public readonly WarframeDB datos;
//        public rivensModel(WarframeDB datos)
//        {
//            this.datos = datos;
//        }
//        public void Insert(Agrietados agrietados)
//        {
//            datos.Agrietados.Add(agrietados);
//            datos.SaveChanges();
//        }
//    }
//}
