﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404.Models
{
    public class CoolingSystemsVM
    {
			public List<CPCoolingSystems> CoolingSystemItems { get; set; }

			public CoolingSystemsVM()
			{
				CoolingSystemItems = new List<CPCoolingSystems>();
			}
		}
}
