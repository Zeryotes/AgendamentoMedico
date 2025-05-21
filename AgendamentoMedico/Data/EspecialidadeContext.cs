using AgendamentoMedico.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoMedico.Data;

public class EspecialidadeContext : DbContext
{
    public DbSet<EspecialidadeModel> Especialidades { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=especialidade.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}