namespace Solution1.Domain.ExampleAggregate.Interceptors
{
	using Fluxera.Repository.Interception;
	using JetBrains.Annotations;
	using Solution1.Domain.ExampleAggregate.Model;

	/// <summary>
	///     A repository interceptor for the example aggregate root.
	/// </summary>
	[UsedImplicitly]
	public sealed class ExampleInterceptor : InterceptorBase<Example, string>
	{
	}
}
