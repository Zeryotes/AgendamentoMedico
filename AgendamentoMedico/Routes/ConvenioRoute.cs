using AgendamentoMedico.Data;
using AgendamentoMedico.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoMedico.Routes;

public static class ConvenioRoute
{
    public static void ConvenioRoutes(this WebApplication app)
    {
        var route = app.MapGroup("convenio");

        route.MapPost("",
            async (ConvenioRequest req, ConvenioContext context) =>
            {
                var convenio = new ConvenioModel(req.nome);
                await context.AddAsync(convenio);
                await context.SaveChangesAsync();
            });

        route.MapGet("",
            async (ConvenioContext context) =>
            {
                var convenios = await context.Convenios.ToListAsync();

                return Results.Ok(convenios);
            });
    }
}