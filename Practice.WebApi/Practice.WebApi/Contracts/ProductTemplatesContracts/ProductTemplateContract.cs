using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.WebApi.Contracts.ProductTemplatesContracts
{
	/// <summary>
	/// Модель контракта Продукта для выдачи данных пользователю
	/// </summary>
	public class ProductTemplateContract
	{
		/// <summary>
		/// Идентификатор ProductTemplate
		/// </summary>
		public string Id { get; set; }

		// <summary>
		/// Название ProductTemplate
		/// </summary>
		public string Name { get; set; }
	}
}
