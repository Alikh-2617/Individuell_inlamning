using Individuell_inlamning.Repository;

namespace Individuell_inlamning
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.

            builder.Services.AddCors(
            x => x.AddPolicy("corsPolicy", builder =>
                {
                    builder.WithOrigins("*").
                    AllowAnyMethod().
                    AllowAnyHeader();
                }));

            // builder.Services.AddScoped<IService, Service>();    

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseCors("corsPolicy");

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.MapGet("/", ()=> "Hello world ! ");
            app.MapControllers();

            app.Run();
        }
    }
}