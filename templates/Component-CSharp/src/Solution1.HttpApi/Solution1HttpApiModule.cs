namespace Solution1.HttpApi
{
	using Fluxera.Extensions.Hosting;
	using Fluxera.Extensions.Hosting.Modules;
	using Fluxera.Extensions.Hosting.Modules.AspNetCore.HttpApi;
	using Fluxera.Extensions.Hosting.Modules.AspNetCore.HttpApi.OData;
	using Fluxera.Extensions.Hosting.Modules.Configuration;
	using JetBrains.Annotations;
	using Solution1.HttpApi.Contributors;

	/// <summary>
	///     The HTTP API module of the component.
	/// </summary>
	[PublicAPI]
	[DependsOn(typeof(HttpApiModule))]
	[DependsOn(typeof(ODataModule))]
	[DependsOn(typeof(ConfigurationModule))]
	public sealed class Solution1HttpApiModule : ConfigureApplicationModule
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

		/// <inheritdoc />
		public override void PreConfigure(IApplicationInitializationContext context)
		{
			context.UseProblemDetails();
		}
	}
}
