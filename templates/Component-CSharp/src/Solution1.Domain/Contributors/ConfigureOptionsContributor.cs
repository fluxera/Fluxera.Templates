namespace Solution1.Domain.Contributors
{
	using Fluxera.Extensions.Hosting.Modules.Configuration;
	using JetBrains.Annotations;

	[UsedImplicitly]
	internal sealed class ConfigureOptionsContributor : ConfigureOptionsContributorBase<Solution1DomainOptions>
	{
		/// <inheritdoc />
		public override string SectionName => "Solution1";
	}
}
