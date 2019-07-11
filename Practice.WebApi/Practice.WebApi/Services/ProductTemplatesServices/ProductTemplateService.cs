using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Practice.Domain;
using Practice.WebApi.Contracts.ProductTemplatesContracts;
using Practice.WebApi.Mapper;

namespace Practice.WebApi.Services.ProductTemplatesServices
{
	public class ProductTemplateService : IProductTemplateService
	{
		DbSet<ProductTemplate> _productTemplates;
		IContractMapper _mapper;

		public ProductTemplateService(DomainContext dc, ContractMapper mapper)
		{
			_productTemplates = dc.Set<ProductTemplate>();
			_mapper = mapper;
		}

		/// <summary>
		/// Функция получения элемента по идентификатору
		/// </summary>
		/// <param name="id">Идентификатор требуемого элемента</param>
		/// <returns>Возвращает элемент с заданным идентификатором
		/// или ошибку если элемент не существует</returns>
		public ProductTemplateContract GetProductTemplate(string id)
		{
			ProductTemplate productTemplates = _productTemplates.Find(id);

			if(productTemplates == null)
			{
				throw new ModelValidationExeption($"Продукт с идентификатором '{id}' не найден!");
			}
			else
			{
				//Преобращование из ProductTemplate в ProductTemplateContractModel
				return _mapper.Map<ProductTemplate, ProductTemplateContract>(productTemplates);
			}
		}

		/// <summary>
		/// Функция получения списка элементов ProductTemplate
		/// </summary>
		/// <param name="filter">Параметры запроса.</param>
		/// <returns>Возвращает весь список элементов или 
		/// отфильтрованный по параметрам filter</returns>
		public List<ProductTemplateContract> GetListProductTemplates(ProductTemplateFilter filter)
		{
			var productTemplates = _productTemplates.AsQueryable();

			if(filter != null)
			{
				//filter.Name параметр для поиска по начальным символам названия
				if (!string.IsNullOrEmpty(filter.Name))
				{
					productTemplates = productTemplates.Where(x => x.Name.ToLower().StartsWith(filter.Name.ToLower()));
				}

				//filter.Title параметр для поиска полного совпадения с именем без учета регистра
				if (!string.IsNullOrEmpty(filter.Title))
				{
					productTemplates = productTemplates.Where(x => x.Name.ToLower() == filter.Title.ToLower());
				}

				//filter.Search параметр для поиска по подстрокам в названии
				if (!string.IsNullOrEmpty(filter.Search))
				{
					productTemplates = productTemplates.Where(x => x.Name.ToLower().Contains(filter.Search.ToLower()));
				}
			}

			//Преобразование из ProductTemplate в ProductTemplateContractModel
			return _mapper.Map<List<ProductTemplate>, List<ProductTemplateContract>>(productTemplates.ToList());
		}
	}
}
