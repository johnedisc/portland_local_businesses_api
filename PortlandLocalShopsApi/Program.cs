using Microsoft.EntityFrameworkCore;
using PortlandLocalShopsApi.Models;

var builder = WebApplication.CreateBuilder(args);

//controller services
builder.Services.AddControllers();
builder.Services.AddDbContext<PortlandLocalShopsApiContext>(opt =>
    opt.UseMySql(
      builder.Configuration["ConnectionStrings:DefaultConnection"],
      ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
        )
      )
    );

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}
else
{
  app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
