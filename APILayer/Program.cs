
using BL.Services.MainServices;
using DAL.AppContext;
using DAL.Repositries.MainRepo;
using DAL.Repositries.PersonRepo;
using Microsoft.EntityFrameworkCore;

namespace APILayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<HotelDbContext>(options =>
            {
                options.UseLazyLoadingProxies().UseSqlServer
                (
                    builder.Configuration.GetConnectionString("Default")
                );
            });
            // Register Repos
            builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
            // builder.Services.AddScoped<IPersonRepository, PersonRepository>();


            builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //inject builderoption

            //builder.Services.AddDbContext<HotelDbContext>
            //builder.Services.AddScoped()
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
