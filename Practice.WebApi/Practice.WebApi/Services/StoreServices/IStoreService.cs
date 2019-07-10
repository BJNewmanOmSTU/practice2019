using Microsoft.AspNetCore.Mvc;
using Practice.Domain;
using Practice.WebApi.Contracts.StoreContracts;
using System.Collections.Generic;


namespace Practice.WebApi.Services
{
	/// <summary>
	/// Интерфейс сервиса для обработки
	/// запросов к модели Store
	/// </summary>
	/// <typeparam name="Store">Модель Store</typeparam>
	public interface IStoreService<Store>
	{
		/// <summary>
		/// Функция получения элемента по идентификатору
		/// </summary>
		/// <param name="id">Идентификатор требуемого элемента</param>
		/// <returns>Возвращает элемент с заданным идентификатором
		/// или ошибку если элемент не существует</returns>
		StoreContract GetStore(string id);

		/// <summary>
		/// Функция получения списка элементов Stores
		/// </summary>
		/// <param name="filter">Параметры запроса.</param>
		/// <returns>Возвращает весь список элементов или 
		/// отфильтрованный по параметрам filter</returns>
		List<StoreContract> GetListStores(StoreFilter filter);
	}
}
