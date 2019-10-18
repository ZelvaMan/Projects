using System.Collections.Generic;

namespace JohnyPetka.DatingService.Web
{
	public class Person
	{
		public enum Hobby
		{
			football,
			skating,
			fishing,
			reading,
			running,
			drawing
		}

		public enum StateEnum
		{
			Away,
			Offline,
			Online
		}

		public string City;
		public List<Hobby> Hobbies;
		public string ImageLink;

		public string Nickname;
		public StateEnum State;

		public Person(string imageLink, string nickname, StateEnum state, string city, List<Hobby> hobbie)
		{
			Hobbies = hobbie;
			State = state;
			Nickname = nickname;
			City = city;
			ImageLink = imageLink;
		}
	}
}