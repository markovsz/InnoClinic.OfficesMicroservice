using Api.Extensions;
using Api.Middlewares;
using Application;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureDb(builder.Configuration);
builder.Services.ConfigureRepositories();
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.ConfigureAuthentication(builder.Configuration);
builder.Services.AddControllers();
builder.Services.ConfigureMediatR();
builder.Services.ConfigureValidators();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionsHandler>();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
