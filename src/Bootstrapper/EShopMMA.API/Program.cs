WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddCatalogModule()
    .AddBasketModule()
    .AddOrderModule();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.

app.Run();
