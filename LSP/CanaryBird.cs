using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
	internal class CanaryBird : Bird, IFly
	{
		public int Longitude { get; set; }
		public int Altitude { get; set; }

		public void Fly()
		{
			// implement fly method...
		}
	}
}
