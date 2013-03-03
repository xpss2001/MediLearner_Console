using System;
using SQLite;

namespace MediLearner_Console.BL.Contracts
{
	public abstract class BusinessEntityBase : IBusinessEntity
	{
		public BusinessEntityBase ()
		{
		}

		[AutoIncrement,PrimaryKey]
		public int ID { get; set; }
	}
}

