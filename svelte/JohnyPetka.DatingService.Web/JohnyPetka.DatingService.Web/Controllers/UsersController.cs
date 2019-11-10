using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JohnyPetka.DatingService.Web.Controler
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		[Route("GetUsers")]
		public ActionResult<Person[]> GetUsers([FromQuery] string nickname, [FromQuery] string city,
			[FromQuery] string[] hobbies, [FromQuery] string state)
		{
			List<Person> people = Filter.FilterPeople(nickname, city, hobbies.ToList(), Person.GetStateEnum(state));
			#region json creation
			JObject o = JObject.FromObject(new
			{
				channel = new
				{

					people =
						from p in people
						orderby p.Nickname
						select new
						{
							imageLink = p.ImageLink,
							nickname = p.Nickname,
							state = p.State,
							city = p.City,
							hobbies = p.Hobbies,

						}
				}
			});
			#endregion
			Debug.WriteLine($"Sended {people.Count} people   -------   {DateTime.Now}");
			return people.ToArray();
		}
	}
}