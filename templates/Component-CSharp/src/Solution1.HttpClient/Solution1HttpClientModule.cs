namespace Solution1.HttpClient
{
	using Fluxera.Extensions.Hosting;
	using Fluxera.Extensions.Hosting.Modules;
	using Fluxera.Extensions.Hosting.Modules.Configuration;
	using Fluxera.Extensions.Hosting.Modules.HttpClient;
	using Fluxera.Extensions.Hosting.Modules.ODataClient;
	using JetBrains.Annotations;
	using Solution1.HttpClient.Contributors;

	/// <summary>
	///     The HTTP client module of the component.
	/// </summary>
	[PublicAPI]
	[DependsOn(typeof(HttpClientModule))]
	[DependsOn(typeof(ODataClientModule))]
	[DependsOn(typeof(ConfigurationModule))]
	public sealed class Solution1HttpClientModule : ConfigureServicesModule
	{
		/// <inheritdoc />
		public override void PreConfigureServices(IServiceConfigurationContext context)
		{
			// Add the options contributor.
			context.Services.AddConfigureOptionsContributor<ConfigureOptionsContributor>();
		}

		/// <inheritdoc />
		public override void ConfigureServices(IServiceConfigurationContext context)
		{
			// TODO: Add the module services here.
		}
	}
}
