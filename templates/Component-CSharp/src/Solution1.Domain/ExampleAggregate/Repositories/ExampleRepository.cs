namespace Solution1.Domain.ExampleAggregate.Repositories
{
	using Fluxera.Repository;
	using JetBrains.Annotations;
	using Solution1.Domain.ExampleAggregate.Model;

	/// <summary>
	///     An implementation of a generic repository that handles example instances.
	/// </summary>
	[UsedImplicitly]
	internal sealed class ExampleRepository : Repository<Example, string>, IExampleRepository
	{
		/// <inheritdoc />
		public ExampleRepository(IRepository<Example, string> innerRepository)
			: base(innerRepository)
		{
		}
	}
}
