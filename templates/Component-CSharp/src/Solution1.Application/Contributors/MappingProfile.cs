namespace Solution1.Application.Contributors
{
	using AutoMapper;
	using JetBrains.Annotations;
	using Solution1.Application.Contracts.Dtos;
	using Solution1.Domain.ExampleAggregate.Model;

	[UsedImplicitly]
	internal sealed class MappingProfile : Profile
	{
		public MappingProfile()
		{
			this.CreateMap<Example, ExampleDto>().ReverseMap();
		}
	}
}
