using Application.Common.Utilities;
using Infrastructure;
using RestApiService.EventLogger.Configuration;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
IWebHostEnvironment environment = builder.Environment;
IConfiguration configuration = builder.Configuration;

#region Host Configuration

builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonProvider(environment);

#endregion Host Configuration

#region Service Configuration

AppSettings appSettings = new();
appSettings = configuration.GetSection("AppSettings").Get<AppSettings>();

builder.Services
    .AddSingleton(appSettings)
    .RegisterServices(configuration)
    .AddMongoDataBase(appSettings.ConnectionString, appSettings.DatabaseName, appSettings);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#endregion Service Configuration

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();