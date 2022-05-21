namespace Solution1.Application.Consumers.Events
{
	using System.Threading.Tasks;
	using DateYourBeauty.Subscription.Domain.Messages.Events;
	using JetBrains.Annotations;
	using MassTransit;
	using Microsoft.Extensions.Logging;

	/// <summary>
	///     A consumer implementation that consumes <see cref="ExampleAdded" /> event messages.
	/// </summary>
	[UsedImplicitly]
	public sealed class ExampleAddedConsumer : IConsumer<ExampleAdded>
	{
		private readonly ILogger<ExampleAddedConsumer> logger;

		/// <summary>
		///     Initializes a new instance of the <see cref="ExampleAddedConsumer" /> type.
		/// </summary>
		public ExampleAddedConsumer(ILogger<ExampleAddedConsumer> logger)
		{
			this.logger = logger;
		}

		/// <inheritdoc />
		public Task Consume(ConsumeContext<ExampleAdded> context)
		{
			this.logger.LogWarning("This consumer does nothing!");

			return Task.CompletedTask;
		}
	}
}
