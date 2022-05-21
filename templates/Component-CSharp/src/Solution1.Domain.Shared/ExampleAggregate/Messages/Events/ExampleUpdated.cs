﻿namespace DateYourBeauty.Subscription.Domain.Messages.Events
{
	using Fluxera.Extensions.Hosting.Modules.Domain.Shared.Messages;
	using JetBrains.Annotations;

	/// <summary>
	///     An event message for notifying than an example was updated.
	/// </summary>
	[PublicAPI]
	public sealed class ExampleUpdated : ItemUpdated
	{
	}
}
