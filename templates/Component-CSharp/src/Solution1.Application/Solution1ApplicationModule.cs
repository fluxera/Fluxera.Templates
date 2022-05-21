namespace Solution1.Application
{
	using Fluxera.Extensions.Hosting;
	using Fluxera.Extensions.Hosting.Modules;
	using Fluxera.Extensions.Hosting.Modules.Application;
	using Fluxera.Extensions.Hosting.Modules.AutoMapper;
	using Fluxera.Extensions.Hosting.Modules.Configuration;
	using Fluxera.Extensions.Hosting.Modules.Messaging;
	using Fluxera.Extensions.Hosting.Modules.Persistence;
	using JetBrains.Annotations;
	using Microsoft.Extensions.DependencyInjection.Extensions;
	using Solution1.Application.Contracts.Services;
	using Solution1.Application.Contributors;
	using Solution1.Application.Services;
	using Solution1.Domain;

	/// <summary>
	///     The application module of the component.
	/// </summary>
	[PublicAPI]
	[DependsOn(typeof(Solution1DomainModule))]
	[DependsOn(typeof(AutoMapperModule))]
	[DependsOn(typeof(PersistenceModule))]
	[DependsOn(typeof(ApplicationModule))]
	[DependsOn(typeof(ConfigurationModule))]
	public sealed class Solution1ApplicationModule : ConfigureServicesModule
	{
		/// <inheritdoc />
		public override void PreConfigureServices(IServiceConfigurationContext context)
		{
			// Add the options contributor.
			context.Services.AddConfigureOptionsContributor<ConfigureOptionsContributor>();

			// Add the repository contributor for the 'Default' repository.
			context.Services.AddRepositoryContributor<RepositoryContributor>("Default");

			// Add the consumers contributor.
			context.Services.AddConsumersContributor<ConsumersContributor>();

			// Add the mapping profile contributor.
			context.Services.AddMappingProfileContributor<MappingProfileContributor>();
		}

		/// <inheritdoc />
		public override void ConfigureServices(IServiceConfigurationContext context)
		{
			// Add the application services.
			context.Services.TryAddTransient<IExampleApplicationService, ExampleApplicationService>();

			// TODO: Add the module services here.
		}
	}
}
