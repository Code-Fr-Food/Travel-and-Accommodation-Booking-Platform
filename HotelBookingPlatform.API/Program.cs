using Serilog;

SerilogConfiguration.ConfigureLogger();
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services
    .AddApplicationDependencies()
    .AddPresentationDependencies(builder.Configuration)
    .AddInfrastructureDependencies()
    .AddSwaggerDocumentation()
    .AddCloudinary(builder.Configuration);

builder.Host.UseSerilog();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerDocumentation();
}

app.UseCors();
app.UseMiddleware<GlobalExceptionHandling>();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
