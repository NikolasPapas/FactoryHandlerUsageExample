using TestFactoryHandlerApplication.Common.Types.Swagger;

namespace TestFactoryHandlerApplication.Core
{
	public static class Extensions
	{
		public static IServiceCollection AddSwagger(this IServiceCollection services, IConfigurationSection configurationSection)
		{
			services.Configure<OpenAPIConfiguration>(configurationSection);

			services.AddSwaggerGen(c =>
			{
				DirectoryInfo dir = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
				foreach (var fi in dir.EnumerateFiles("*.xml"))
					c.IncludeXmlComments(fi.FullName);

				c.CustomSchemaIds(type => type.ToString());
			});
			services.AddSwaggerGenNewtonsoftSupport();
			return services;
		}

		public static IApplicationBuilder ConfigureSwagger(this IApplicationBuilder app)
		{
			app.UseSwagger();
			app.UseSwaggerUI(c =>
			{
			});
			return app;
		}
	}
}
