using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SQLite;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
////builder.Services.AddSqlite("Data Source=./DataStore/VAappsSurvey.db");

//builder.Services.AddSqlite<StudentContext>("Data Source=./DataStore/student.db");

builder.Services.AddDbContext<StudentContext>
    (options => options.UseSqlite("Data Source=./DataStore/Student.db"));

//services.AddDbContext<SurveyContext>
//    (options => options.UseSqlite(connection));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
