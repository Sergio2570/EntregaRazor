using System;
using System.Collections.Generic;

namespace EntregaRazor.Models
{
    public partial class Agrietados
    {
        public string Nombre { get; set; }
        public string Arma { get; set; }
        public string Buff1 { get; set; }
        public decimal Valor1 { get; set; }
        public string? Buff2 { get; set; }
        public decimal? Valor2 { get; set; }
        public string? Buff3 { get; set; }
        public decimal? Valor3 { get; set; }
        public string? DeBuff { get; set; }
        public decimal? ValorDebuff { get; set; }
        public string Propietario { get; set; }
        public Agrietados(string nombre,string arma, string buff1, decimal valor1, string? buff2, decimal? valor2, string? buff3, decimal? valor3, string? debuff, decimal? valordebuff,string propietario)
        {
            this.Nombre = nombre;
            this.Arma = arma;
            this.Buff1 = buff1;
            this.Valor1 = valor1;
            this.Buff2 = buff2;
            this.Valor2 = valor2;
            this.Buff3 = buff3;
            this.Valor3 = valor3;
            this.DeBuff = debuff;
            this.ValorDebuff = valordebuff;
            this.Propietario = propietario;
        }
    }
    
}