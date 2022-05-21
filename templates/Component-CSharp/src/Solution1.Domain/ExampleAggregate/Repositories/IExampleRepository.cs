namespace Solution1.Domain.ExampleAggregate.Repositories
{
	using Fluxera.Repository;
	using JetBrains.Annotations;
	using Solution1.Domain.ExampleAggregate.Model;

	/// <summary>
	///     A contract for a repository that handles example instances.
	/// </summary>
	[PublicAPI]
	public interface IExampleRepository : IRepository<Example, string>
	{
	}
}
