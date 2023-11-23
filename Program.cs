using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projectoef;
using projectoef.Models;

var builder = WebApplication.CreateBuilder(args);
// BD en memoria
//builder.Services.AddDbContext<TareasContext>(options => options.UseInMemoryDatabase("TareasDB"));

//conexion "ConnectionString" alojado en appsettings.jason PostgreSQL
builder.Services.AddNpgsql<TareasContext>(builder.Configuration.GetConnectionString("TareasDB"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconection", ([FromServices] TareasContext dbContext) =>
{
    // responde ok 200 True si esta conectado a memoria False si no
    dbContext.Database.EnsureCreated();
    return Results.Ok("base de datos en memoria: " + dbContext.Database.IsInMemory());

}
);

//endpoint con parametros de busqueda
app.MapGet("/api/tareas", ([FromServices] TareasContext dbContext) =>
{
    return Results.Ok(dbContext.Tareas.Where(p => p.Titulo == "Tarea 2"));
});
//trae todas las tareas de la BD    
app.MapGet("/api/tareas1", ([FromServices] TareasContext dbContext) =>
{
    return Results.Ok(dbContext.Tareas);
});

//agregar nuevos datos
app.MapPost("/api/tareas1", async ([FromServices] TareasContext dbContext, [FromBody] Tarea tarea) =>
{
    try
    {
        tarea.TareaId = Guid.NewGuid();
        tarea.FechaCreacion = DateTime.UtcNow;
        await dbContext.AddAsync(tarea);
        await dbContext.SaveChangesAsync();

        return Results.Ok();
    }
    catch (Exception ex)
    {
        // Manejar la excepción, por ejemplo, registrándola
        Console.Error.WriteLine($"Error al agregar tarea: {ex.Message}");
        return Results.BadRequest("Error al agregar tarea");
    }
});

//modificar datos existentes
app.MapPut("/api/tareas1/{id}", async ([FromServices] TareasContext dbContext, [FromBody] Tarea tarea, [FromRoute] Guid id) =>
{
    var tareaActual = await dbContext.Tareas.FindAsync(id);

    if(tareaActual != null)
    {
        tareaActual.CategoriaId = tarea.CategoriaId;
        tareaActual.Titulo = tarea.Titulo;
        tareaActual.PrioridadTarea = tarea.PrioridadTarea;
        tareaActual.Descripcion = tarea.Descripcion;

        await dbContext.SaveChangesAsync();
        return Results.Ok();
    }

    

    return Results.NotFound();
});
//delete datos existentes
app.MapDelete("/api/tareas1/{id}", async ([FromServices] TareasContext dbContext, [FromRoute] Guid id) =>
{
    var tareaActual = await dbContext.Tareas.FindAsync(id);
    if(tareaActual != null )
    {
        dbContext.Tareas.Remove(tareaActual);
        await dbContext.SaveChangesAsync();

        return Results.Ok();
    }
    return Results.NotFound();
});

app.Run();
