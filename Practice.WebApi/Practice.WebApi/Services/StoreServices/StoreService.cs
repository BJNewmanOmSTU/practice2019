using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice.Domain;
using Practice.WebApi.Contracts.StoreContracts;
using Practice.WebApi.Mapper;
using Practice.WebApi.Services.StoreServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace Practice.WebApi.Services
{
	/// <summary>
	/// Сервис для работы с моделью Store
	/// </summary>
	public class StoreService : IStoreService<Store>
	{
		private DbSet<Store> _store;
		private IContractMapper _mapper;

		/// <summary>
		/// Конструктор сервиса StoreService
		/// </summary>
		/// <param name="dc">Контекст базы данных</param>
		/// <param name="mapper">Mapper для сопоставления модели с контрактом</param>
		public StoreService(DomainContext dc, ContractMapper mapper)
		{
			_store = dc.Set<Store>();
			_mapper = mapper;
		}

		/// <summary>
		/// Функция получения элемента по идентификатору
		/// </summary>
		/// <param name="id">Идентификатор требуемого элемента</param>
		/// <returns>Возвращает элемент с заданным идентификатором
		/// или ошибку если элемент не существует</returns>
		public StoreContractModel GetStore(string id)
		{
		    Store store = _store.Find(id);

			if (store == null)
			{
				throw new StoreNotFoundException($"Элемент с идентификатором '{id}' не найден!!!");
			}
			else
			{
				return _mapper.Map<Store, StoreContractModel>(store);
			}
		}

		/// <summary>
		/// Функция получения списка элементов Stores
		/// </summary>
		/// <param name="filter">Параметры запроса.</param>
		/// <returns>Возвращает весь список элементов или 
		/// отфильтрованный по параметрам filter</returns>
		public List<StoreContractModel> GetListStores(StoreFilterModel filter)
		{
			var stores = _store.AsQueryable();

			if (filter != null)
			{
				//filter.Name параметр для поиска по начальным символам названия
				if (!string.IsNullOrEmpty(filter.Name))
				{
					stores = stores.Where(x => x.Name.ToLower().StartsWith(filter.Name.ToLower()));
				}

				//filter.Title параметр для поиска полного совпадения с именем без учета регистра
				if (!string.IsNullOrEmpty(filter.Title))
				{
					stores = stores.Where(x => x.Name.ToLower() == filter.Title.ToLower());
				}

				//filter.Search параметр для поиска по подстрокам в названии
				if (!string.IsNullOrEmpty(filter.Search))
				{
					stores = stores.Where(x => x.Name.ToLower().Contains(filter.Search.ToLower()));
				}

				//Если в stores пусто то выбрасывается исключение
				if (!stores.Any())
				{
					throw new StoreNotFoundException("Данные соответствующие данному запросу не найдены!");
				}
			}

			//Преобращование из Store в StoreContractModel
			return _mapper.Map<List<Store>, List<StoreContractModel>>(stores.ToList());
		}
	}
}
