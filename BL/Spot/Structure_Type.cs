using System;

namespace MediLearner_Console.BL
{
	public class Structure_Type : Contracts.BusinessEntityBase
	{
		public string name { get; set; }
		public string created { get; set; }
		public string modified { get; set; }

		public Structure_Type ()
		{
		}
	}
}

