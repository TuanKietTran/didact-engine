using DidactEngine.Services.BackgroundServices;
using DidactEngine.Services.Contexts;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.OpenApi.Models;
using System.Reflection;
using DidactCore.Flows;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "DevelopmentCORS",
        policy =>
        {
            policy.WithOrigins("http://localhost:8080");
            policy.AllowAnyMethod();
            policy.AllowAnyHeader();
            policy.AllowCredentials();
        });
});

#region Configure DbContext and Gateway.

var connStringFactory = (string name) => new SqlConnectionStringBuilder(
    builder.Configuration.GetConnectionString(name))
{
    ApplicationName = "Didact",
    PersistSecurityInfo = true,
    MultipleActiveResultSets = true,
    WorkstationID = Environment.MachineName,
    TrustServerCertificate = true
}.ConnectionString;

builder.Services.AddDbContext<DidactDbContext>(
    (sp, opt) =>
    {
        opt.UseMemoryCache(sp.GetRequiredService<IMemoryCache>());
        opt.UseSqlServer(connStringFactory("Didact"), opt => opt.CommandTimeout(110));
        if (builder.Configuration.GetValue<bool?>("EnableSensitiveDataLogging").GetValueOrDefault())
        {
            opt.EnableDetailedErrors();
            opt.EnableSensitiveDataLogging();
        }
    });

#endregion Configure DbContext and Gateway.

builder.Services.AddControllers();
builder.Services.AddMemoryCache();

// Register Swagger
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
string swaggerVersion = "v1";
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc(swaggerVersion, new OpenApiInfo
    {
        Version = swaggerVersion,
        Title = "Didact REST API",
        Description = "The central REST API of the Didact Engine."
    });

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});
builder.Services.AddEndpointsApiExplorer();

// Register BackgroundServices
builder.Services.AddHostedService<WorkerBackgroundService>();
// Register Flow helper services from DidactCore.
//builder.Services.AddSingleton<IFlowExecutor, FlowExecutor>();
// Register repositories from DidactCore.
//builder.Services.AddScoped<IFlowRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseCors("DevelopmentCORS");
}

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

var logger = app.Services.GetRequiredService<ILogger<Program>>();

try
{
    using (var scope = app.Services.CreateScope())
    using (var dbContext = scope.ServiceProvider.GetRequiredService<DidactDbContext>())
    try
    {
        logger.LogInformation("Attempting to migrate the database on engine startup...");
        dbContext.Database.Migrate();
        logger.LogInformation("Database migrated successfully.");
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "Unhandled exception while applying migrations for {T}", typeof(DidactDbContext));
        throw;
    }

    app.Run();
    return 0;
}
catch (Exception ex)
{
    logger.LogCritical(ex, "An unhandled exception occurred during bootstrapping");
    return 1;
}