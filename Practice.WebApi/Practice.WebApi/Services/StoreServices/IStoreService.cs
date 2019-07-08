using Microsoft.AspNetCore.Mvc;
using Practice.Domain;
using System.Collections.Generic;


namespace Practice.WebApi.Services
{
	public interface IStoreService<Store>
	{
		ActionResult<Store> GetStore(string id);
		List<Store> GetListStores(SearchStore searchStore);
	}
}
