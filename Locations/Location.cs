using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salkodev.robobackup.Locations
{
	class Location
	{
		public Location()
		{
		}

		/// <summary>
		/// Папка которую требуется бекапить. Можно задать корень диска (C:\)
		/// </summary>
		public string SourceFolder
		{
			get;
			set;
		}

		/// <summary>
		/// Папка-назначение. Здесь можно указать вообще другое имя, например оригинальная папка была C:\, а здесь можно \\BACKUP\Share\Drive_C\
		/// </summary>
		public string DestinationFolder
		{
			get;
			set;
		}

		/// <summary>
		/// Копировать только файлы (но не папки) из указанного источника. Полезно для корневой папки диска.
		/// </summary>
		public bool FilesOnly
		{
			get;
			set;
		}


	}
}
