using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404.Models
{
    public class MiscCablesVM
    {
		public List<AMiscCables> MiscCableItems { get; set; }

		public MiscCablesVM()
		{
			MiscCableItems = new List<AMiscCables>();
		}
	}
}
