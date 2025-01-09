using Microsoft.EntityFrameworkCore;
using SwaggerThemes;
using TaskManagmentSystem.BL;
using TaskManagmentSystem.DAL;
using TaskManagmentSystem.DAL.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SqlContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Lab"));
});

builder.Services.AddControllers();
builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();
//builder.Services.AddFluentValidation();
builder.Services.AddHttpContextAccessor();
builder.Services.AddAutoMapper();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(Theme.UniversalDark);
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
