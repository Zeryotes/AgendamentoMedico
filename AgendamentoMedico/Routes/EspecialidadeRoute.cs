using AgendamentoMedico.Data;
using AgendamentoMedico.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoMedico.Routes;

public static class EspecialidadeRoute
{
    public static void EspecialidadeRoutes(this WebApplication app)
    {
        var route = app.MapGroup("especialidade");

        route.MapPost("",
            async (EspecialidadeRequest req, EspecialidadeContext context) =>
            {
                var especialidade = new EspecialidadeModel(req.nome);
                await context.AddAsync(especialidade);
                await context.SaveChangesAsync();
            });
        
        route.MapGet("", async (EspecialidadeContext context) =>
        {
            var especialidades = await context.Especialidades.ToListAsync();
            
            return Results.Ok(especialidades);
        });

    }
}