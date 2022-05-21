namespace Solution1.Application.Contributors
{
	using Fluxera.Extensions.Hosting;
	using Fluxera.Extensions.Hosting.Modules.Messaging;
	using JetBrains.Annotations;
	using MassTransit;
	using Solution1.Application.Consumers.Events;

	[UsedImplicitly]
	internal sealed class ConsumersContributor : IConsumersContributor
	{
		/// <inheritdoc />
		public void ConfigureConsumers(IRegistrationConfigurator configurator, IServiceConfigurationContext context)
		{
			configurator.AddConsumer<ExampleAddedConsumer>();
		}
	}
}
