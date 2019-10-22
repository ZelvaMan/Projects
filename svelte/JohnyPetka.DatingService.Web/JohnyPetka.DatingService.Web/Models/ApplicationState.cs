using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohnyPetka.DatingService.Web
{
	public static  class ApplicationState
	{
		public static List<Person> People { get; set; } = LoadPeople();

		public static List<Person> LoadPeople()
		{
			var LoadedPeople = new List<Person>();

			#region Adding People

			LoadedPeople.Add(new Person("https://i.pravatar.cc/400?img=1", "Honza", Person.StateEnum.Online,
				"Ostrava",new List<string>(){ "running", "skating"}));

			LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=1",
				 "Nick",
				 Person.GetStateEnum("Offline"),
				 "Ostrava",
				new List<string>(){

				"fishing",
				"running",
				"drawing"
				}
			));
			LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=2",
				 "Nick2",
				 Person.GetStateEnum("Offline"),
				 "Ostrava",
				new List<string>(){
				"football",
				"skating",
				"fishing",
				"reading",
				"running",
				"drawing"
				}
			));
			LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=3",
				 "Nick3",
				 Person.GetStateEnum("Online"),
				 "Opava",
				new List<string>(){
				"running",
				"skating"
				}
			));
			LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=4",
				 "Nick4",
				 Person.GetStateEnum("Offline"),
				 "Praha",
				new List<string>(){
				"running",
				"drawing"
				}
			));
			LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=5",
				 "Nick5",
				 Person.GetStateEnum("Away"),
				 "Brno",
				new List<string>(){
				"football",
				"skating",

				"drawing"
				}
			));
			LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=6",
				 "Nick6",
				 Person.GetStateEnum("Offline"),
				 "Brno",
				new List<string>(){
				"football",
				"skating",

				"running"
				}
			)); LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=7",
				 "Nick7",
				 Person.GetStateEnum("Offline"),
				 "Ostrava",
				new List<string>(){
				"football",
				"skating",
				"fishing",
				"reading",
				"running",
				"drawing"
				}


			));
			LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=2=8",
				 "Nick8",
				 Person.GetStateEnum("Offline"),
				 "Ostrava",
				new List<string>(){
				 "skating",
				 "fishing",
				 "drawing"
				}
			));
			LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=9",
				 "Nick9",
				 Person.GetStateEnum("Online"),
				 "Opava",
				new List<string>(){
				"football"

				}
			));
			LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=10",
				 "Nick10",
				 Person.GetStateEnum("Offline"),
				 "Praha",
				new List<string>(){
				"football",
				 "skating",

				}
			));
			LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=11",
				 "Nick11",
				 Person.GetStateEnum("Away"),
				 "Brno",
				new List<string>(){

				 "drawing"
				}
			));
			LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=12",
				 "Nick12",
				 Person.GetStateEnum("Offline"),
				 "Brno",
				new List<string>(){
				"football",

				 "drawing"
				}
			)); LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=13",
				 "Nick13",
				 Person.GetStateEnum("Offline"),
				 "Ostrava",
				new List<string>(){
				"football",
				 "fishing",
				 "reading",
				 "drawing"
				}
			));
			LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=14",
				 "Nick14",
				 Person.GetStateEnum("Offline"),
				 "Ostrava",
				new List<string>(){
				"football",
				 "skating",
				 "fishing",
				 "reading",
				 "running",
				 "drawing"
				}
			));
			LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=15",
				 "Nick15",
				 Person.GetStateEnum("Online"),
				 "Opava",
				new List<string>(){
				"football",

				 "running",
				 "drawing"
				}
			));
			LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=16",
				 "Nick16",
				 Person.GetStateEnum("Offline"),
				 "Praha",
				new List<string>(){

				 "drawing"
				}
			));
			LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=17",
				 "Nick17",
				 Person.GetStateEnum("Away"),
				 "Brno",
				new List<string>(){
				 "skating",
				 "fishing",
				 "reading",
				 "running"
				}
			));
			LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=18",
				 "Nick18",
				 Person.GetStateEnum("Offline"),
				 "Brno",
				new List<string>(){
				"football",
				 "skating",
				 "fishing",
				 "reading",
				 "running",
				 "drawing"
				}
			)); LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=19",
				 "Nick19",
				 Person.GetStateEnum("Offline"),
				 "Ostrava",
				new List<string>()
				{
				}
			));
			LoadedPeople.Add(new Person(
				 "https://i.pravatar.cc/400?img=20",
				 "Nick20",
				 Person.GetStateEnum("Offline"),
				 "Ostrava",
				new List<string>(){
				"football",
				 "skating",
				 "fishing",
				 "running",
				 "drawing"
				}
			));

			#endregion

			return LoadedPeople;
		}
	}
}
