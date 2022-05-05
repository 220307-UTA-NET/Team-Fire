using Microsoft.OpenApi.Models;
using Project2EntityFramework.Data;
using Project2EntityFramework.Models;

namespace Project2EntityFramework
{
    public class StartUp
    {
        public StartUp(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EmployeeAPI", Version = "v1" });
            });
            //services.AddDbContext<SunCardBackend2Context>(opt => opt.UseMySql(Configuration["DefaultConnectionString"],new MySqlServerVersion(8,0,11)));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>c.SwaggerEndpoint("/swagger/v1/swagger.json", "CustomerAPi v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
        }
    }
}
