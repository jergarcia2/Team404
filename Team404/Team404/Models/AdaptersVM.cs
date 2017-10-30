using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404.Models
{
    public class AdaptersVM
    {
		public List<AAdapters> AdaptersItems { get; set; }

		public AdaptersVM()
		{
			AdaptersItems = new List<AAdapters>();
		}
	}
}
