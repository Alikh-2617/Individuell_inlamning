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

            app.MapGet("/", ()=> "Hej !! \nvi har två funktioner för att kryptera och dekryptera lössen ord med en nycker vilken är siffra och ett namn och lössenordet som ska krypteras ,"+
            " för att dekryptera lössen ordet bör du säga ditt namn och kryperade lössen ordet ! \n\n\tHost Domain/encrypt => { string:namn ID, string:lössenord, int:key } för att krypera lösenordet "+
            "\n\n\tHost Domain/decrypt => {string:name ID, string:krypterade } för att krypera lösenordet "+
            "\n\n\tLycka till !");
            app.MapControllers();

            app.Run();
        }
    }
}