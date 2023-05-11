using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
	internal class Bird
	{
		private string color;

		public string Color
		{
			get { return color; }
			protected set { color = value; }
		}

		public enum BeakTypes
		{
			MeatEater,
			SeedEater,
			NectarFeeder
		}

		public void LayEggs()
		{
			// implement code to laying eggs.....
		}
	}
}
