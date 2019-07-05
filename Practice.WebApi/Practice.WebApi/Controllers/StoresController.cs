using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice.Domain;
using Practice.WebApi.Services;

namespace Practice.WebApi.Controllers
{
	[Route("stores")]
	public class StoresController : Controller
	{
		DbSet<Store> Store;
		IModelValidate<Store> _sv;
		public StoresController(DomainContext db, StoreValid sv)
		{
			//_dc = db;
			Store = db.Set<Store>();
			_sv = sv;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public ActionResult<List<Store>> GetStores()
		{			
			if(!_sv.Get(out List<Store> st))
				return BadRequest("Нет записей Stores!");
			else
				return st;
		}
				
		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public ActionResult<Store> Get(string id)
		{
			if (!_sv.TryGetItem(id, out Store st)) {
				return BadRequest("Не найдено!");
			}
			return st;
		}
	}
}
