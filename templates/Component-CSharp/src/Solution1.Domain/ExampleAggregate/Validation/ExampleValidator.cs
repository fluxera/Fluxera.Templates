namespace Solution1.Domain.ExampleAggregate.Validation
{
	using FluentValidation;
	using JetBrains.Annotations;
	using Solution1.Domain.ExampleAggregate.Model;

	/// <summary>
	///     A validator that validates example instances.
	/// </summary>
	[UsedImplicitly]
	public sealed class ExampleValidator : AbstractValidator<Example>
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ExampleValidator" /> type.
		/// </summary>
		public ExampleValidator()
		{
			this.RuleFor(x => x.Name)
				.NotEmpty()
				.MaximumLength(100);
		}
	}
}
