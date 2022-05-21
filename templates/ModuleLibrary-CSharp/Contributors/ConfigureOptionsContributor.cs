﻿namespace Project1.Contributors
{
	using Fluxera.Extensions.Hosting.Modules.Configuration;
	using JetBrains.Annotations;

	[UsedImplicitly]
	internal sealed class ConfigureOptionsContributor : ConfigureOptionsContributorBase<Module1ModuleOptions>
	{
		/// <inheritdoc />
		public override string SectionName => "{module}";
	}
}