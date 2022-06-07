namespace Project1.Contributors
{
	using Fluxera.Extensions.Hosting.Modules.Configuration;
	using JetBrains.Annotations;

	[UsedImplicitly]
	internal sealed class ConfigureOptionsContributor : ConfigureOptionsContributorBase<Module1Options>
	{
		/// <inheritdoc />
		public override string SectionName => "Module1";
	}
}
