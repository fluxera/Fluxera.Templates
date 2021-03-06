namespace Solution1.Application.Contracts.Dtos
{
	using Fluxera.Extensions.Hosting.Modules.Application.Contracts.Dtos;
	using JetBrains.Annotations;
	using Solution1.Domain.Shared.ExampleAggregate.Model;

	/// <summary>
	///     A dto that provides the data of an example.
	/// </summary>
	[PublicAPI]
	public sealed class ExampleDto : EntityDto<string>
	{
		/// <summary>
		///     Gets or sets the name of the example.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		///     Gets or sets the kind of the example.
		/// </summary>
		public ExampleKind Kind { get; set; }

		/// <summary>
		///     Gets or sets the title of the example detail.
		/// </summary>
		public string DetailTitle { get; set; }

		/// <summary>
		///     Gets or sets the text of the example detail.
		/// </summary>
		public string DetailText { get; set; }
	}
}
