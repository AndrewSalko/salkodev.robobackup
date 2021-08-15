using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salkodev.robobackup.Robo
{
	class Copy: ICopy
	{
		public const string ROBO_COPY_EXE = "robocopy.exe";

		public Copy()
		{
		}

		public void CopyFolder(string sourceFolder, string destionationFolder, bool filesOnly)
		{
			string optionFilesOnly = filesOnly ? "/LEV:1" : string.Empty;

			string args = $"\"{sourceFolder}\" \"{destionationFolder}\"  /mir {optionFilesOnly}";

			var pi = new ProcessStartInfo(ROBO_COPY_EXE, args);
			//pi.WindowStyle = ProcessWindowStyle.Hidden;

			var proc = Process.Start(pi);
			proc.WaitForExit();

			//TODO@: анализировать возврат-код
		}

	}
}
