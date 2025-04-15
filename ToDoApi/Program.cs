var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<ToDoApi.Interfaces.ITarefaRepository, ToDoApi.DAL.TarefaRepository>();
builder.Services.AddScoped<ToDoApi.Interfaces.ITarefaService, ToDoApi.BLL.TarefaService>();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();
app.Run();