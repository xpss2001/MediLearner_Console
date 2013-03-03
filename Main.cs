using System;
using SQLite;
using Path = System.IO.Path;

namespace MediLearner_Console
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
//			var dbPath = Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments), "MLDB.db");
			var dbPath = "MLDB.db";
			var db = new SQLiteConnection (dbPath);
			db.BeginTransaction ();

			db.CreateTable<BL.Marker> ();
//			db.Insert (new marker () {
//				symbol = "r=B=",
//				preparation_side = 0,
//				structure_id = 1,
//				preparation_side_id = 1,
//				created = "2013-02-12 20:08:23",
//				modified = "2013-02-12 20:08:23"
//
//			});
//
			var Markers = db.Table<BL.Marker> ();
			foreach (BL.Marker ms in Markers)
			{
				Console.WriteLine("ID " + ms.ID + ": " + ms.symbol);
			}
////			Console.WriteLine (db.Table<marker> ().Skip(6).FirstOrDefault ().symbol);
			db.Commit ();
			Console.ReadLine ();
		}
	}


}
