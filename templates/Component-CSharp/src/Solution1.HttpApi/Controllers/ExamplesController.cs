namespace Solution1.HttpApi.Controllers
{
	using System.Threading.Tasks;
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;
	using Solution1.Application.Contracts.Dtos;
	using Solution1.Application.Contracts.Services;

	/// <summary>
	///     The examples controller.
	/// </summary>
	[ApiController]
	[AllowAnonymous]
	[Route("examples")]
	public class ExamplesController : ControllerBase
	{
		private readonly IExampleApplicationService exampleApplicationService;

		/// <summary>
		///     Initializes a new instance of the <see cref="ExamplesController" /> type.
		/// </summary>
		/// <param name="exampleApplicationService"></param>
		public ExamplesController(IExampleApplicationService exampleApplicationService)
		{
			this.exampleApplicationService = exampleApplicationService;
		}

		/// <summary>
		///     Gets an example by ID.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpGet("{id:required}")]
		public async Task<IActionResult> GetByID(string id)
		{
			ExampleDto result = await this.exampleApplicationService.GetExampleAsync(id);

			if(result is null)
			{
				return this.NotFound(id);
			}

			return this.Ok(result);
		}

		/// <summary>
		///     Adds an example.
		/// </summary>
		/// <param name="dto"></param>
		/// <returns></returns>
		[HttpPost]
		public async Task<IActionResult> Add(ExampleDto dto)
		{
			if(!this.ModelState.IsValid)
			{
				return this.BadRequest(this.ModelState);
			}

			ExampleDto result = await this.exampleApplicationService.AddExample(dto);

			return this.CreatedAtAction(nameof(this.GetByID), new { id = result.ID }, result);
		}
	}
}
