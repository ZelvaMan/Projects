using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonAspNet.Models
{
	public class Singleton 
	{
		public int Number { get; private set; }

		public void IncreaseNumber()
		{
			Number++;
		}
	}
}
