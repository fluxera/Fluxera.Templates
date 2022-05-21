namespace Solution1.Application.Contributors
{
	using Fluxera.Extensions.Hosting.Modules.Configuration;
	using JetBrains.Annotations;

	[UsedImplicitly]
	internal sealed class ConfigureOptionsContributor : ConfigureOptionsContributorBase<Solution1ApplicationModuleOptions>
	{
		/// <inheritdoc />
		public override string SectionName => "{component}";
	}
}
