using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Practice.Domain;
using Practice.Domain.Repository;

namespace Practice.WebApi.Controllers
{
	[Route("[controller]")]
	public class StoresController : Controller
	{
		IRepository<Store> db;

		public StoresController(DomainContext db)
		{
			this.db = new StoreRepository(db);
		}

		[HttpGet]
		public IEnumerable<Store> GetStores()
		{
			return db.GetAll();
		}
				
		[HttpGet("{id}")]
		public Store Get(string id)
		{
			return db.Get(id);
		}
	}
}
