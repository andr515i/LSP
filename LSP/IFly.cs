using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
	internal interface IFly
	{
		public int Longitude { get; set; }
		public int Altitude { get; set; }

		public void Fly();
	}
}
