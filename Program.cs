using System;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using salkodev.robobackup.Locations;

namespace salkodev.robobackup
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("SalkoDev.Robo backup");

			try
			{
				string appDir = System.AppContext.BaseDirectory;

				var builder = new ConfigurationBuilder().
					SetBasePath(appDir).
					AddJsonFile("appsettings.json", optional: false);

				IConfiguration config = builder.Build();

				var locStorage = config.GetSection(LocationStorage.LocationStorageKey).Get<LocationStorage>();
				locStorage.FixEscapeInPaths();

				var copy = new Robo.Copy();

				var backup = new Backup(copy);
				backup.Process(locStorage.Locations);

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}
	}
}
