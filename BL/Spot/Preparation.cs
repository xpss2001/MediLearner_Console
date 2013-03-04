using System;

namespace MediLearner_Console.BL.Spot
{
	public class Preparation : Contracts.BusinessEntityBase
	{
		public string name { get; set; }
		public string showcase { get; set; }
		public string title { get; set; }
		public string subtitle { get; set; }
		public string created { get; set; }
		public string modified { get; set; }

		public Preparation ()
		{
		}
	}
}

