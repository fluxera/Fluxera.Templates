namespace ServiceHost1
{
	using System.Threading.Tasks;
	using Fluxera.Extensions.Hosting;

	internal static class Program
	{
		public static async Task Main(string[] args)
		{
			await ApplicationHost.RunAsync<ServiceHost1Host>(args);
		}
	}
}
