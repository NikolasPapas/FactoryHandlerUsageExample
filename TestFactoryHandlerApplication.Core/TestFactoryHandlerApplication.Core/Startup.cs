using TestFactoryHandlerApplication.Common.Controllers;
using TestFactoryHandlerApplication.Common.Implementations;
using TestFactoryHandlerApplication.Common.Interfaces;

namespace TestFactoryHandlerApplication.Core
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            RegisterCommonServices(services);
            RegisterExternalServices(services);

            services.AddSwagger(this.Configuration.GetSection("OpenAPI"));
            services.AddControllers()
                .AddApplicationPart(typeof(TestFactoryHandlerContoller).Assembly);
        }

        private void RegisterCommonServices(IServiceCollection services)
        {
            // Add you Common service and Configuration initialization
            services.AddTransient<IMainService, MainService>();
            services.AddSingleton<IHandlerFactory, HandlerFactory>();
        }

        private void RegisterExternalServices(IServiceCollection services)
        {
            // Add you External service and Configuration initialization
            //services.AddScoped<CompanyHandler>();
            //services.AddScoped<EmployerHandler>();
            //services.AddScoped<CustomerHandler>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.ConfigureSwagger();
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}