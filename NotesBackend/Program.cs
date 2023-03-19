using Microsoft.EntityFrameworkCore;
using NotesBackend.Model;

var builder = WebApplication.CreateBuilder(args);

//Added dbcontext 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<NotesDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("NotesDbContext")));


// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(policy => policy.AllowAnyHeader()
                    .AllowAnyMethod()
                    .SetIsOriginAllowed(Origin => true)
                    .AllowCredentials());


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
