using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice.Domain;
using Practice.WebApi.Contracts.StoreContracts;
using Practice.WebApi.Services;
using Practice.WebApi.Services.StoreServices;

namespace Practice.WebApi.Controllers
{
	[Route("stores")]
	public class StoresController : AController
	{
		DbSet<Store> _stores;
		IStoreService<Store> _storeService;

		/// <summary>
		/// Конструктор контроллера StoresController
		/// </summary>
		/// <param name="db">Контекст базы данных</param>
		/// <param name="storeService">Сервис для работы со Store</param>
		public StoresController(DomainContext db, StoreService storeService)
		{
			_stores = db.Set<Store>();
			_storeService = storeService;
		}

		/// <summary>
		/// Get запрос для получения списка элементов
		/// </summary>
		/// <param name="searchStore">Модель с нужными полями для фильтрации</param>
		/// <returns>Возвращает весь список элементов Store
		/// или отфильтрованный по параметрам,
		/// если элементы не найдены возвращает ошибку</returns>
		[HttpGet]
		public ActionResult<List<StoreContractModel>> GetListStores(StoreFilterModel searchStore)
		{			
			return _storeService.GetListStores(searchStore);			
		}

		/// <summary>
		/// Get запрос для получения
		/// элемента по Id
		/// </summary>
		/// <param name="id">Идентификатор требуемого элемента</param>
		/// <returns>Возвращает элемент Store
		/// соответствующий данному идентификатору
		/// или ошибку поиска</returns>
		[HttpGet("{id}")]
		public ActionResult<StoreContractModel> Get(string id)
		{		
			return _storeService.GetStore(id);			
		}
	}
}
