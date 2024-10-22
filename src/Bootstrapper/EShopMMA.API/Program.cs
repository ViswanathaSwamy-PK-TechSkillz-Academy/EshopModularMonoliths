using Catalog.Extensions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddCatalogModule(builder.Configuration);
//.AddBaskeyModule(builder.Configuration)
//.AddOrderModule(builder.Configuration);

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.

app.Run();
