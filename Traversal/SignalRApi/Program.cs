using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SignalRApi.DAL;
using SignalRApi.Hubs;
using SignalRApi.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<VisitorService>();

builder.Services.AddSignalR();
builder.Services.AddCors(options => options.AddPolicy("CorsPolicy", build =>
{
    build.AllowAnyHeader()
         .AllowAnyMethod()
         .SetIsOriginAllowed((host) => true)
         .AllowCredentials();
}));

builder.Services.AddEntityFrameworkNpgsql().AddDbContext<Context>((serviceProvider, options) =>
{
    var configuration = serviceProvider.GetRequiredService<IConfiguration>();
    var connectionString = configuration.GetConnectionString("DefaultConnection");
    options.UseNpgsql(connectionString);
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");
app.UseAuthorization();


app.MapControllers();
app.MapHub<VisitorHub>("/VisitorHub");

app.Run();
