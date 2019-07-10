using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice.Domain;
using Practice.WebApi.Contracts.ProductTemplatesContracts;
using Practice.WebApi.Services.ProductTemplatesServices;

namespace Practice.WebApi.Controllers
{
	[Route("productTemplates")]
	public class ProductTemplatesController : AController
	{
		private IProductTemplateService _productTemplateService;

		/// <summary>
		/// Конструктор контроллера ProductTemplatesController
		/// </summary>
		/// <param name="productTemplateService">Сервис для работы с моделью ProductTemplate</param>
		public ProductTemplatesController(ProductTemplateService productTemplateService)
		{
			_productTemplateService = productTemplateService;
		}

		/// <summary>
		/// Get запрос для получения списка элементов
		/// </summary>
		/// <param name="filter">Класс с полями для фильтрации</param>
		/// <returns>Возвращает весь список элементов ProductTemplate
		/// или отфильтрованный по параметрам,
		/// если элементы не найдены возвращает ошибку</returns>
		[HttpGet]
		public ActionResult<List<ProductTemplateContract>> GetListProductTemplates(ProductTemplateFilter filter)
		{
			return _productTemplateService.GetListProductTemplates(filter);
		}

		/// <summary>
		/// Get запрос для получения
		/// элемента по Id
		/// </summary>
		/// <param name="id">Идентификатор требуемого элемента</param>
		/// <returns>Возвращает элемент ProductTemplate
		/// соответствующий данному идентификатору
		/// или ошибку поиска</returns>
		[HttpGet("{id}")]
		public ActionResult<ProductTemplateContract> GetProductTemplate(string id)
		{
			return _productTemplateService.GetProductTemplate(id);
		}
	}
}
