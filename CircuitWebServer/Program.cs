var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// µù¥U CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowMVCClient",
        policy => policy.WithOrigins("https://localhost:7239") // MVC ºô§}
                        .AllowAnyHeader()
                        .AllowAnyMethod());
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// ¨Ï¥Î CORS
app.UseCors("AllowMVCClient");

app.UseAuthorization();

app.MapControllers();

app.Run();
