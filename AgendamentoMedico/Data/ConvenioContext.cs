using AgendamentoMedico.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoMedico.Data;

public class ConvenioContext : DbContext
{
    public DbSet<ConvenioModel> Convenios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=convenio.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}