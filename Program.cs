
using PizzaService.Orders;

OrderProcessor orderProcessor = new OrderProcessor();

OrderServiceController.NewOrderEvent += orderProcessor.ProcessOrder;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "PizzaService");
                c.RoutePrefix = string.Empty;
            });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
