
using Microsoft.EntityFrameworkCore;
using School.Models;
using School.Models.Repositories;
using School.Repositories;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvc(option => option.EnableEndpointRouting = false);
builder.Services.AddScoped<ISchoolRepository<Teacher>,TeacherRepo>();
builder.Services.AddScoped<ISchoolRepository<Student>, StudentRepo>();
builder.Services.AddScoped<ISchoolRepository<Rank>, RankRepo>();
builder.Services.AddScoped<ISchoolRepository<Subject>, SubjectRepo>();
builder.Services.AddScoped<ISchoolRepository<SubjectRank>, SubjectRankRepo>();
builder.Services.AddDbContext<SchoolDbContext>(options
    => options.UseSqlServer
    (builder.Configuration.GetConnectionString("sqlcon")

));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseMvcWithDefaultRoute();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
