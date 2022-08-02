using Cinema.Contexts;
using Cinema.Services.Repositories;
using Cinema.Services.UnitsOfWork;
using CinemaWebApi.Services.UnitsOfWork;
using Microsoft.EntityFrameworkCore;

namespace Cinema
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration["ConnectionStrings:MoiveDBConection"];
            builder.Services.AddDbContext<MovieContext>(o => o.UseSqlServer(connectionString));

            builder.Services.AddControllers();


        }

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration["ConnectionString:MoiveDBConectionString"];
            services.AddDbContext<MovieContext>(o => o.UseSqlServer(connectionString));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IReviewsRepository, ReviewsRepository>();

            services.AddScoped<IUserUnitOfWork, UserUnitOfWork>();
            services.AddScoped<IMovieUnitOfWork, MovieUnitOfWork>();
        }

        public static void Configure(WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

        }
    }
}

