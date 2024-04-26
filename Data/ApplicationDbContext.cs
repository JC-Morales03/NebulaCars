using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace NebulaCars.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {}
    public DbSet<NebulaCars.Models.Contacto> DataContacto {get; set; }
    public DbSet<NebulaCars.Models.Producto> DataProducto {get; set; }
    public DbSet<NebulaCars.Models.Proforma> DataItemCarrito {get; set; }
    public DbSet<NebulaCars.Models.Proforma> DataCita {get; set; }

}
