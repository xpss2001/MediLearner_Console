using System;


namespace MediLearner_Console.BL
{
	public class Marker : Contracts.BusinessEntityBase
	{
		public string symbol { get; set; }
		public string text { get; set; }
		public int preparation_side { get; set; }
		public int structure_id { get; set; }
		public int preparation_side_id { get; set; }
		public string created { get; set; }
		public string modified { get; set; }
		
		
		public override string ToString ()
		{
			return ID.ToString();
		}
	}
}

