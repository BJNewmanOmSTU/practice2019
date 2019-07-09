using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.WebApi.Contracts.ProductTemplatesContracts
{
	/// <summary>
	/// Класс для фильтрации по полям ProductTemplate
	/// </summary>
	public class ProductTemplateFilterModel
	{
		/// <summary>
		/// Параметр для поиска по начальным символам названия ProductTemplate
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Параметр для поиска по полному совпадению с названием ProductTemplate
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Параметр для поиска по подстрокам в названии ProductTemplate
		/// </summary>
		public string Search { get; set; }
	}
}
