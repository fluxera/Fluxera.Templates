namespace Solution1.Application.Contributors
{
	using DateYourBeauty.Subscription.Domain.EventHandlers;
	using Fluxera.Extensions.Hosting;
	using Fluxera.Extensions.Hosting.Modules.Persistence;
	using Solution1.Domain.ExampleAggregate.Interceptors;
	using Solution1.Domain.ExampleAggregate.Model;

	internal sealed class RepositoryContributor : IRepositoryContributor
	{
		/// <inheritdoc />
		public void ConfigureAggregates(IRepositoryAggregatesBuilder builder, IServiceConfigurationContext context)
		{
			builder.UseFor<Example>();
		}

		/// <inheritdoc />
		public void ConfigureDomainEventHandlers(IDomainEventHandlersBuilder builder, IServiceConfigurationContext context)
		{
			builder
				.AddDomainEventHandler<ExampleAddedHandler>()
				.AddDomainEventHandler<ExampleUpdatedHandler>()
				.AddDomainEventHandler<ExampleRemovedHandler>();
		}

		/// <inheritdoc />
		public void ConfigureValidators(IValidatorsBuilder builder, IServiceConfigurationContext context)
		{
			//builder.AddValidator<ExampleValidator>();
		}

		/// <inheritdoc />
		public void ConfigureInterceptors(IInterceptorsBuilder builder, IServiceConfigurationContext context)
		{
			builder.AddInterceptor<ExampleInterceptor>();
		}

		/// <inheritdoc />
		public void ConfigureCaching(ICachingBuilder builder, IServiceConfigurationContext context)
		{
			builder.UseNoCaching();
		}
	}
}
