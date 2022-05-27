namespace Solution1.HttpClient.Contributors
{
	using Fluxera.Extensions.Hosting.Modules.Configuration;
	using JetBrains.Annotations;

	[UsedImplicitly]
	internal sealed class ConfigureOptionsContributor : ConfigureOptionsContributorBase<Solution1HttpClientOptions>
	{
		/// <inheritdoc />
		public override string SectionName => "Solution1";
	}
}
