using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Practice.Domain;
using Practice.WebApi.Contracts.StoreContracts;
using Practice.WebApi.Services;
namespace Practice.WebApi.Controllers
{
	/// <summary>
	/// Контроллер для работы с Магазинами
	/// </summary>
	[Route("stores")]
	public class StoresController : AController
	{
		private IStoreService _storeService;

		/// <summary>
		/// Конструктор контроллера StoresController
		/// </summary>
		/// <param name="storeService">Сервис для работы со Store</param>
		public StoresController(StoreService storeService)
		{
			_storeService = storeService;
		}

		/// <summary>
		/// Get запрос для получения списка элементов
		/// </summary>
		/// <param name="filter">Модель с нужными полями для фильтрации</param>
		/// <returns>Возвращает весь список элементов Store
		/// или отфильтрованный по параметрам,
		/// если элементы не найдены возвращает ошибку</returns>
		[HttpGet]
		public ActionResult<List<StoreContract>> GetListStores(StoreFilter filter)
		{			
			return _storeService.GetListStores(filter);			
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
		public ActionResult<StoreContract> Get(string id)
		{		
			return _storeService.GetStore(id);			
		}
	}
}
