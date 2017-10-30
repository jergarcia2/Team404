using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404.Models
{
    public class StorageDevicesVM
    {
		public List<AStorageDevices> StorageDevicesItems { get; set; }

		public StorageDevicesVM()
		{
			StorageDevicesItems = new List<AStorageDevices>();
		}
	}
}
