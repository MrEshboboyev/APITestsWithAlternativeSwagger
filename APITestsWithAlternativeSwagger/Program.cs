var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

// adding OpenApi services
builder.Services.AddOpenApi();

var app = builder.Build();

// using static files 
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

// using openAPI
app.MapOpenApi("/docs/api/openapi.json");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
