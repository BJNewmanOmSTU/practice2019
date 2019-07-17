using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.WebApi.Contracts.ProductTemplatesContracts
{
	/// <summary>
	/// Класс для фильтрации по полям ProductTemplate
	/// </summary>
	public class ProductTemplateFilter
	{
		/// <summary>
		/// Параметр для поиска по начальным символам названия Шаблона продукта
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Параметр для поиска по полному совпадению с названием Шаблона продукта
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Параметр для поиска по подстрокам в названии Шаблона продукта
		/// </summary>
		public string Search { get; set; }
	}
}
