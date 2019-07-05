using Microsoft.EntityFrameworkCore;
using Practice.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.WebApi.Services
{
	public class StoreValid : IModelValidate<Store>
	{
		DbSet<Store> Store;
			public StoreValid(DomainContext dc)
		{
			Store = dc.Set<Store>();
		}
		public bool Get(out List<Store> stores)
		{
			stores = Store.Include(p => p.Codes).ToList();
			if (stores.Count == 0)
				return false;
			else
				return true;
		}

		public bool TryGetItem(string id, out Store store)
		{
			store = Store.Find(id);
			if (store == null)
				return false;
			else
				return true;
		}
	}
}
