using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404.Models
{
    public class ProcessorsVM
    {
		public List<CPProcessors> ProcessorsItems { get; set; }

		public ProcessorsVM()
		{
			ProcessorsItems = new List<CPProcessors>();
		}
	}
}
