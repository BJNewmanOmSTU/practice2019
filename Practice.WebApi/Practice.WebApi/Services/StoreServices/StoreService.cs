using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice.Domain;
using Practice.WebApi.Services.StoreServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace Practice.WebApi.Services
{
	public class StoreService : IStoreService<Store>
	{
		private DbSet<Store> _store;
			public StoreService(DomainContext dc)
		{
			_store = dc.Set<Store>();
		}

		public ActionResult<Store> GetStore(string id)
		{
			Store store = _store.Find(id);
			string msg = "";
			if (store == null) { 
				msg = "Store с идентификатором '" + id + "' не найден!!!";
				throw new StoreNotFoundException();
			}
			else
				return store;
		}

		public List<Store> GetListStores(SearchStore filter)
		{
			var stores = _store.AsQueryable();

			if (filter != null)
			{
				if (!string.IsNullOrEmpty(filter.name)){ 
					stores = stores.Where(x => x.Name.ToLower().Contains(filter.name.ToLower()));
				}
				if (!string.IsNullOrEmpty(filter.title)) { 
					stores = stores.Where(x => x.Name.ToLower() == filter.title.ToLower());
				}
				if (!string.IsNullOrEmpty(filter.search)){}
			}

			return stores.ToList();
		}
	}
}
