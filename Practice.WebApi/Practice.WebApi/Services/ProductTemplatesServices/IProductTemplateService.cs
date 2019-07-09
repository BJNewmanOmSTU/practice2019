using Practice.Domain;
using Practice.WebApi.Contracts.ProductTemplatesContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.WebApi.Services.ProductTemplatesServices
{
	/// <summary>
	/// Интерфейс сервиса для обработки
	/// запросов к модели ProductTemplate
	/// </summary>
	/// <typeparam name="Store">Модель Store</typeparam>
	public interface IProductTemplateService
	{
		/// <summary>
		/// Функция получения элемента по идентификатору
		/// </summary>
		/// <param name="id">Идентификатор требуемого элемента</param>
		/// <returns>Возвращает элемент с заданным идентификатором
		/// или ошибку если элемент не существует</returns>
		ProductTemplateContractModel GetProductTemplate(string id);

		/// <summary>
		/// Функция получения списка элементов ProductTemplate
		/// </summary>
		/// <param name="filter">Параметры запроса</param>
		/// <returns>Возвращает весь список элементов или 
		/// отфильтрованный по параметрам filter</returns>
		List<ProductTemplateContractModel> GetListProductTemplates(ProductTemplateFilterModel filter);
	}
}
