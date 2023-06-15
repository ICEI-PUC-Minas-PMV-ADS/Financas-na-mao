using FinancasNaMaoMVC.Areas.Identity.Data;
using FinancasNaMaoMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancasNaMaoMVC.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<Usuario>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ }
    public DbSet<Lancamento> Lancamentos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Provento> Proventos { get; set; }
    public DbSet<Usuario> Usuario { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}


public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.Property(u => u.Nome).HasMaxLength(20);
        builder.Property(u => u.Sobrenome).HasMaxLength(40);
        builder.Property(u => u.Contato).HasMaxLength(20);
        builder.Property(u => u.isUsuarioAtivo);
    }
}