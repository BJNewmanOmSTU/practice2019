using System.Collections.Generic;
using System.Linq;
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
			//Code = db.Set<Code>();
		}

		[HttpGet]
		public Store GetStores()
		{
			return Store.FirstOrDefault();
		}
				
		/*[HttpGet("{id}")]
		public Store Get(string id)
		{
			return db.Get(id);
		}*/
	}
}
