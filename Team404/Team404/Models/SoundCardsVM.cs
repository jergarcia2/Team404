﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404.Models
{
    public class SoundCardsVM
    {
		public List<CPSoundCards> SoundCardsItems { get; set; }

		public SoundCardsVM()
		{
			SoundCardsItems = new List<CPSoundCards>();
		}
	}
}
