using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404.Models
{
    public class MemoryVM
    {
		public List<CPMemory> MemoryItems { get; set; }

		public MemoryVM()
		{
			MemoryItems = new List<CPMemory>();
		}
	}
}
