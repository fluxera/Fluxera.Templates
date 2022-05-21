namespace Solution1.HttpApi.Contributors
{
	using Fluxera.Extensions.Hosting.Modules.Configuration;
	using JetBrains.Annotations;

	[UsedImplicitly]
	internal sealed class ConfigureOptionsContributor : ConfigureOptionsContributorBase<Solution1HttpApiModuleOptions>
	{
		/// <inheritdoc />
		public override string SectionName => "{component}";
	}
}
