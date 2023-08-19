using nTier_RepositoryPattern.BussinessLayer.Abstract;
using nTier_RepositoryPattern.BussinessLayer.Concrete;
using nTier_RepositoryPattern.DataAccesLayer.Abstract;
using nTier_RepositoryPattern.DataAccesLayer.Concrete;
using nTier_RepositoryPattern.DataAccesLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<IAuthorDal, EfAuthorDal>();
builder.Services.AddScoped<IAuthorService, AuthorManager>();

builder.Services.AddCors(x => x.AddPolicy("Cors", builder => 
{
	builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("Cors");
app.UseAuthorization();

app.MapControllers();

app.Run();
