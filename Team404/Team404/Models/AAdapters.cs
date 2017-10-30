using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404.Models
{
    public class AAdapters
    {
		public string ItemTitle { get; set; }
		public List<string> MiniDescription { get; set; }
		public string ItemLink { get; set; }
		public string ItemPrice { get; set; }
		public AAdapters()
		{
			MiniDescription = new List<string>();
		}
	}
}
