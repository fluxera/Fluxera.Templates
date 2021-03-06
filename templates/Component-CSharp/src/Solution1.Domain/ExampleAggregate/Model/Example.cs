namespace Solution1.Domain.ExampleAggregate.Model
{
	using Fluxera.Entity;
	using JetBrains.Annotations;
	using Solution1.Domain.Shared.ExampleAggregate.Model;

	/// <summary>
	///     An aggregate root holding the information of an example.
	/// </summary>
	/// <seealso cref="AggregateRoot{TAggregateRoot,TKey}" />
	[PublicAPI]
	public sealed class Example : AggregateRoot<Example, string>
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
		///     Gets or sets the example detail.
		/// </summary>
		public ExampleDetail Detail { get; set; }
	}
}
