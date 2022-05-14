
namespace TestFactoryHandlerApplication.Common.Types.Swagger
{
	public class OpenAPIConfiguration
	{
		public string DocumentVersion { get; set; }
		public string DocumentTitle { get; set; }
		public string EndpointUrl { get; set; }
		public string EndpointName { get; set; }
		public ClientAuthentication ClientAuthentication { get; set; }
	}

	public class ClientAuthentication
	{
		public string GetAccessTokenEndpoint { get; set; }
		public string ClientID { get; set; }
		public string ClientSecret { get; set; }
		public string Scope { get; set; }
	}
}
