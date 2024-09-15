using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Prometheus;

var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços do Prometheus
builder.Services.AddControllers();

var app = builder.Build();

// Middleware para expor métricas
app.UseRouting();
app.UseHttpMetrics();

app.MapControllers();
app.MapMetrics(); // Expor as métricas em /metrics

app.Run("http://0.0.0.0:80");
