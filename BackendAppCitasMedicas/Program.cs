using Microsoft.EntityFrameworkCore;
using BackendAppCitasMedicas.Data;

var builder = WebApplication.CreateBuilder(args);

// Agrega el DbContext
builder.Services.AddDbContext<Sistema_De_Citas_MedicasContextSQLServer>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Sistema_De_Citas_MedicasContextSQLServer")));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
