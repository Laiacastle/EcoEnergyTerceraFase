using EcoEnergyTerceraFase.Data;
using EcoEnergyTerceraFase.Models;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer("name=DefaultConnection")
    .UseSeeding((context, _) =>
    {
        string consumStringPath = "./wwwroot/BaseFiles/consum_aigua_cat_per_comarques.csv";
        string indicatorStringPath = "./wwwroot/BaseFiles/indicadors_energetics_cat.csv";
        var consumExist = context.Set<ConsumAigua>().Any();
        if (!consumExist)
        {
            List<ConsumAigua> consums = ApplicationDbIniatilazer.ReadConsumes(consumStringPath).ToList();
            List<IndicadorsEnergetics> indicators = ApplicationDbIniatilazer.ReadIndicators(indicatorStringPath).ToList();
            foreach (var consum in consums)
            {
                context.Set<ConsumAigua>().Add(consum);
            }
            foreach (var indicator in indicators)
            {
                context.Set<IndicadorsEnergetics>().Add(indicator);
            }
            context.SaveChanges();

        }
    }
    )
    .UseAsyncSeeding(async (context, _, CancellationToken) =>
    {
        var indicatorsExists = await context.Set<IndicadorsEnergetics>().AnyAsync();
        if (!indicatorsExists)
        {
            string consumStringPath = "../wwwroot/BaseFiles/consum_aigua_cat_per_comarques.csv";
            string indicatorStringPath = "../wwwroot/BaseFiles/indicadors_energetics_cat.csv";
            List<ConsumAigua> consums = ApplicationDbIniatilazer.ReadConsumes(consumStringPath).ToList();
            List<IndicadorsEnergetics> indicators = ApplicationDbIniatilazer.ReadIndicators(indicatorStringPath).ToList();
            foreach (var consum in consums)
            {
                await context.Set<ConsumAigua>().AddAsync(consum);
            }
            foreach (var indicator in indicators)
            {
                await context.Set<IndicadorsEnergetics>().AddAsync(indicator);
            }
            context.SaveChangesAsync();
        }
    }));
    

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<ApplicationDbContext>();
        var appDbInit = new ApplicationDbIniatilazer(context);
        appDbInit.Seed();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Error in database execution");
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
