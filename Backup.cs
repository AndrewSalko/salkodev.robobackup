using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using salkodev.robobackup.Locations;
using salkodev.robobackup.Robo;

namespace salkodev.robobackup
{
	class Backup
	{
		ICopy _Copy;

		public Backup(ICopy copy)
		{
			_Copy = copy ?? throw new ArgumentNullException(nameof(copy));
		}

		public void Process(Location[] locations)
		{
			if (locations == null || locations.Length == 0)
				throw new ArgumentNullException(nameof(locations));

			foreach (var loc in locations)
			{
				_Copy.CopyFolder(loc.SourceFolder, loc.DestinationFolder, loc.FilesOnly);

			}//foreach

		}

	}
}
