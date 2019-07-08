using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice.Domain;
using Practice.WebApi.Services;
using Practice.WebApi.Services.StoreServices;

namespace Practice.WebApi.Controllers
{
	[Route("stores")]
	public class StoresController : Controller
	{
		DbSet<Store> _stores;
		IStoreService<Store> _storeService; // переим
		public StoresController(DomainContext db, StoreService storeService)
		{
			_stores = db.Set<Store>();
			_storeService = storeService;
		}
		
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public ActionResult<List<Store>> GetListStores(SearchStore searchStore)
		{
			List<Store> res = _storeService.GetListStores(searchStore);
			if (!res.Any())
				return BadRequest("Не найдено!");
			return res.ToList();
		}

		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public ActionResult<Store> Get(string id)
		{
			try { 
			return _storeService.GetStore(id);
			}catch(Exception ex)
			{
				return NotFound(ex.Message);
			}
		}
	}
}
