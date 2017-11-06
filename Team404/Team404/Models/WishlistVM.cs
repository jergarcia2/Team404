using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404.Models
{
	public class WishlistVM
	{

		public List<Wishlist> ListItems { get; set; }

		public WishlistVM()
		{
			ListItems = new List<Wishlist>();
		}
	}
}