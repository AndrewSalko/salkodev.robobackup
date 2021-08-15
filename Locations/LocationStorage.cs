using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salkodev.robobackup.Locations
{
	class LocationStorage
	{
		public const string LocationStorageKey = "LocationStorage";

		public Location[] Locations
		{
			get;
			set;
		}

		public void FixEscapeInPaths()
		{
			if (Locations == null)
				return;

			foreach (var loc in Locations)
			{
				loc.DestinationFolder = _FixPath(loc.DestinationFolder);
				loc.SourceFolder = _FixPath(loc.SourceFolder);
			}

		}

		string _FixPath(string path)
		{
			if (string.IsNullOrEmpty(path))
				return path;

			var pathUpdated = path.Replace("/", @"\");
			return pathUpdated;
		}

	}
}
