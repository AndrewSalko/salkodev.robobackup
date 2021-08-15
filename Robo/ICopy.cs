using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salkodev.robobackup.Robo
{
	interface ICopy
	{
		void CopyFolder(string sourceFolder, string destionationFolder, bool filesOnly);
	}
}
