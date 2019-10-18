using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohnyPetka.DatingService.Web
{
	public static  class ApplicationState
	{
		public static  List<Person> People { get; set; } = new List<Person>();

		public static void LoadPeople()
		{
			People = new List<Person>();
			People.Add(new Person("https://i.pravatar.cc/400?img=1", "Honza", Person.StateEnum.Online,
					"Ostrava",new List<Person.Hobby>() { Person.Hobby.drawing, Person.Hobby.fishing, Person.Hobby.reading }));
		}
	}
}
