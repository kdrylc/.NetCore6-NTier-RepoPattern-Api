using nTier_RepositoryPattern.DataAccesLayer.Abstract;
using nTier_RepositoryPattern.DataAccesLayer.Concrete;
using nTier_RepositoryPattern.BussinessLayer.Abstract;
using nTier_RepositoryPattern.BussinessLayer.Concrete;
using nTier_RepositoryPattern.DataAccesLayer.EntityFramework;
using nTier_RepositoryPattern.Entity;
using nTier_RepositoryPattern.Entity.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>();


builder.Services.AddScoped<IBookDal, EfBookDal>();
builder.Services.AddScoped<IBookService, BookManager>();



builder.Services.AddScoped<IAuthorDal, EfAuthorDal>();
builder.Services.AddScoped<IAuthorService, AuthorManager>();



builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
