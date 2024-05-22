using Microsoft.EntityFrameworkCore;
using SignalRApiForSql.Dal;
using SignalRApiForSql.Hubs;
using SignalRApiForSql.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseSqlServer(connectionString);
});

builder.Services.AddScoped<VisitorService>();
builder.Services.AddSignalR();
builder.Services.AddCors(options => options.AddPolicy("CorsPolicy", build =>
{
    build.AllowAnyHeader()
         .AllowAnyMethod()
         .SetIsOriginAllowed((host) => true)
         .AllowCredentials();
}));

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
