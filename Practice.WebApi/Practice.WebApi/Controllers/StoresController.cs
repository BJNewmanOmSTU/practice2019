using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice.Domain;


namespace Practice.WebApi.Controllers
{
	[Route("stores")]
	public class StoresController : Controller
	{
		DbSet<Store> Store;
		public StoresController(DomainContext db)
		{
			Store = db.Set<Store>();
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public ActionResult<Store> GetStores()
		{
			if(!Store.Any())
			{
				return NotFound("Не найдено!");
			}
			return Store.Include(p => p.Codes).FirstOrDefault();
		}
				
		/*[HttpGet("{id}")]
		public Store Get(string id)
		{
			return db.Get(id);
		}*/
	}
}
