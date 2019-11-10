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
			Online,
			SelectState
		}

		public string City;
		public List<string> Hobbies;
		public string ImageLink;

		public string Nickname;
		public StateEnum State;

		public Person(string imageLink, string nickname, StateEnum state, string city, List<string> hobbie)
		{
			Hobbies = hobbie;
			State = state;
			Nickname = nickname;
			City = city;
			ImageLink = imageLink;
		}

		public static StateEnum GetStateEnum(string enumstring)
		{
			switch (enumstring)
			{
				case "Offline":
					return StateEnum.Offline;
				break;
				case "Online":
					return StateEnum.Online;
				break;
				case "Away":
					return StateEnum.Away;
				break;
			}

			return StateEnum.SelectState;
		}
	}
}