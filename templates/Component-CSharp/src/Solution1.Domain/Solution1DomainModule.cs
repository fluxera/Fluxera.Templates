namespace Solution1.Domain
{
	using Fluxera.Extensions.Hosting;
	using Fluxera.Extensions.Hosting.Modules;
	using Fluxera.Extensions.Hosting.Modules.Configuration;
	using Fluxera.Extensions.Hosting.Modules.Domain;
	using Fluxera.Extensions.Hosting.Modules.Messaging;
	using JetBrains.Annotations;
	using Microsoft.Extensions.DependencyInjection.Extensions;
	using Solution1.Domain.Contributors;
	using Solution1.Domain.ExampleAggregate.Repositories;

	/// <summary>
	///     The domain module of the component.
	/// </summary>
	[PublicAPI]
	[DependsOn(typeof(DomainModule))]
	[DependsOn(typeof(MessagingModule))]
	[DependsOn(typeof(ConfigurationModule))]
	public sealed class Solution1DomainModule : ConfigureServicesModule
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
			// Add repositories.
			context.Log("AddRepositories", services =>
				services.TryAddTransient<IExampleRepository, ExampleRepository>());
		}
	}
}
