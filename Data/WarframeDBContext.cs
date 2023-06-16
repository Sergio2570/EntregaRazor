using EntregaRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace EntregaRazor.Data
{
    public class WarframeDBContext : DbContext
    {
        public WarframeDBContext(DbContextOptions<WarframeDBContext> options)
            : base(options)
        {
        }

        public DbSet<Agrietados> Agrietados { get; set; }
    }

}
