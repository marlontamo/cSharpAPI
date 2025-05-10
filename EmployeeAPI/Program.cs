using EmployeeAPI.Services; // Assuming this is where your ApplicationDbContext is
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseSqlServer(connectionString);
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// *** Add this code to configure CORS to allow all origins ***
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", // You can choose any name for your policy
        policy =>
        {
            policy.AllowAnyOrigin()
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// *** Add this middleware to enable CORS ***
app.UseCors("AllowAllOrigins"); // Apply the CORS policy here, before authorization

app.UseAuthorization();

app.MapControllers();

app.Run();
