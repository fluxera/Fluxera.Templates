namespace Solution1.Application.Contracts.Services
{
	using System.Threading.Tasks;
	using JetBrains.Annotations;
	using Solution1.Application.Contracts.Dtos;

	/// <summary>
	///     A contract for application service implementations for client and service side.
	/// </summary>
	[PublicAPI]
	public interface IExampleApplicationService
	{
		/// <summary>
		///     Get an example by ID.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		Task<ExampleDto> GetExampleAsync(string id);

		/// <summary>
		///     Add an example.
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		Task<ExampleDto> AddExample(ExampleDto item);
	}
}
