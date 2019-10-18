using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Remotion.Linq.Clauses;

namespace JohnyPetka.DatingService.Web
{
	public class Filter
	{
		public List<Person> FilterPeople(string nickname, string city, List<Person.Hobby> hobbies, Person.StateEnum state)
		{
			var filtered = ApplicationState.People;
			if (nickname != null)
			{
				 filtered = (from person in filtered
											where (person.Nickname == nickname)
					select person).ToList();
			}
			if (city != null)
			{
				 filtered = (from person in filtered
											where (person.City == city)
					select person).ToList();
			}
			if (state != null)
			{
				 filtered = (from person in filtered
											where (person.State == state)
					select person).ToList();
			}
			if (hobbies != null || hobbies.Count != 0)
			{
				filtered = (from person in filtered
					where (hobbies.Intersect(person.Hobbies).Count() > 0)
					select person).ToList();
			}

			if (state != null)
			{
				filtered = (from person in filtered
					where (person.State == state)
					select person).ToList();

			}

			return filtered;

		}
	}
}
