using Microsoft.EntityFrameworkCore;
using WebApplication1.DataBase;
using WebApplication1.Repository;
using WebApplication1.Repository.Interfaces;
using WebApplication1.Service;
using WebApplication1.Service.Interfaces;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            string connection = Environment.GetEnvironmentVariable("ConnectionString");
            builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connection));
            
            builder.Services.AddTransient<IQuestionRepository, QuestionRepository>();
            builder.Services.AddTransient<IAnswerRepository, AnswerRepository>();
            builder.Services.AddTransient<IResultRepository, ResultRepository>();


            builder.Services.AddTransient<IQuestionService, QuestionService>();
            builder.Services.AddTransient<IResultService, ResultService>();

            var app = builder.Build();

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
        }
    }
}
