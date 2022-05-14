
using NLog.Web;

namespace TestFactoryHandlerApplication.Core
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")?.ToLower();
			var logger = NLogBuilder.ConfigureNLog($"nlog.{environment}.config").GetCurrentClassLogger();

			try
			{
				logger.Info("Web Api Started");
				CreateHostBuilder(args).Build().Run();
			}
			catch (Exception ex)
			{
				logger.Fatal(ex, "Host terminated unexpectedly");
				throw;
			}
			finally
			{
				NLog.LogManager.Shutdown();
			}
		}

		public static IHostBuilder CreateHostBuilder(string[] args)
		{
			return Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>()
					.UseSetting(WebHostDefaults.DetailedErrorsKey, "true")
					.CaptureStartupErrors(true);
				})
				.ConfigureLogging(builder =>
				{
					builder.ClearProviders();
				})
				.UseNLog();
		}
	}
}