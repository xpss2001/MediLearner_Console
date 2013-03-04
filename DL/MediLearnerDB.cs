using System;
using SQLite;
using MediLearner_Console.BL.Spot;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace MediLearner_Console.DL
{
	public class MediLearnerDB : SQLiteConnection
	{
		protected static MediLearnerDB me = null;
		protected static string dbLocation;

		static object locker = new object ();

		protected MediLearnerDB (string path) : base(path)
		{
			//Constructor: Create The Tables
			CreateTable<Marker> ();
			CreateTable<Preparation> ();
			CreateTable<Structure> ();
			CreateTable<Structure_Type> ();
		}

		static MediLearnerDB ()
		{
			// Static Constructor
			dbLocation = DatabaseFilePath;
			me = new MediLearnerDB (dbLocation);
		}

		public static string DatabaseFilePath { get {return "MLDB.db";}}

		public static T GetItem<T> (int id) where T : BL.Contracts.IBusinessEntity, new ()
		{
			lock (locker) {

// Two ways of doing this:

//				return (from i in me.Table<T>()
//				        where i.ID == id
//				        select i).FirstOrDefault();

				return me.Table<T>().FirstOrDefault(x => x.ID == id);
			}
		}

		public static IEnumerable<T> GetItems<T> () where T: BL.Contracts.IBusinessEntity, new ()
		{
			lock (locker) {
				return (from i in me.Table<T>() select i).ToList();
			}
		}



	}
}

