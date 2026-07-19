using DatabaseMastery.TransportationMongoDb.Entities;
using DatabaseMastery.TransportationMongoDb.Services.AboutServices;
using DatabaseMastery.TransportationMongoDb.Services.BrandServices;
using DatabaseMastery.TransportationMongoDb.Services.OfferServices;
using DatabaseMastery.TransportationMongoDb.Services.SliderServices;
using DatabaseMastery.TransportationMongoDb.Services.GetInTouchServices;
using DatabaseMastery.TransportationMongoDb.Services.HowItWorkServices;
using DatabaseMastery.TransportationMongoDb.Services.TestimonialServices;
using DatabaseMastery.TransportationMongoDb.Services.ProjectSectionService;


using DatabaseMastery.TransportationMongoDb.Settings;
using Microsoft.Extensions.Options;
using System.Reflection;
using DatabaseMastery.TransportationMongoDb.Services.QuestionServices;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ISliderService, SliderService>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<IOfferService, OfferService>();
builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<IGetInTouchService, GetInTouchService>();
builder.Services.AddScoped<IHowItWorkService, HowItWorkService>();
builder.Services.AddScoped<ITestimonialService, TestimonialService>();
builder.Services.AddScoped<IProjectSectionService, ProjectSectionService>();
builder.Services.AddScoped<IQuestionService, QuestionService>();


builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettingsKey"));
builder.Services.AddScoped<IDatabaseSettings>(sp =>
{
    return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});



builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
