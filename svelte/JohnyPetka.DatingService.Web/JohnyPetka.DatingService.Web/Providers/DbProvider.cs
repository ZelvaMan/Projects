using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace JohnyPetka.DatingService.Web.Providers
{
	public static class DbProvider
	{
		public  static void Connect()
		{
			var connString = "Host=ubu-001.km8.es;Username=janrada;Password=Votruba je Pan;Database=johnypjetka";

			 var conn = new NpgsqlConnection(connString);
			 conn.Open();


			 var cmd = new NpgsqlCommand("SELECT * FROM user_profile", conn);

			 NpgsqlDataReader dr = cmd.ExecuteReader();
			 while (dr.Read())
					Debug.WriteLine(dr[1]);
		}
	}
}
