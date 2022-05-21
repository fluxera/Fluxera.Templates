namespace Solution1.Application.Services
{
	using System.Threading.Tasks;
	using AutoMapper;
	using JetBrains.Annotations;
	using Solution1.Application.Contracts.Dtos;
	using Solution1.Application.Contracts.Services;
	using Solution1.Domain.ExampleAggregate.Model;
	using Solution1.Domain.ExampleAggregate.Repositories;

	[UsedImplicitly]
	internal sealed class ExampleApplicationService : IExampleApplicationService
	{
		private readonly IMapper mapper;
		private readonly IExampleRepository repository;

		public ExampleApplicationService(IExampleRepository repository, IMapper mapper)
		{
			this.repository = repository;
			this.mapper = mapper;
		}

		/// <inheritdoc />
		public async Task<ExampleDto> GetExampleAsync(string id)
		{
			Example entity = await this.repository.GetAsync(id);
			ExampleDto dto = this.mapper.Map<ExampleDto>(entity);

			return dto;
		}

		/// <inheritdoc />
		public async Task<ExampleDto> AddExample(ExampleDto item)
		{
			Example entity = this.mapper.Map<Example>(item);
			await this.repository.AddAsync(entity);
			ExampleDto dto = this.mapper.Map<ExampleDto>(entity);

			return dto;
		}
	}
}
