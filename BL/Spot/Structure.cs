using System;

namespace MediLearner_Console.BL.Spot
{
	public class Structure : Contracts.BusinessEntityBase
	{
		public string name { get; set; }
		public int structure_type_id { get; set; }
		public string created { get; set; }
		public string modified { get; set; }

		public Structure ()
		{
		}
	}
}

