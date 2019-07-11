using Practice.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Attribute = Practice.Domain.Attribute;

namespace Practice.WebApi.Contracts.CodeContracts
{
	/// <summary>
	/// Класс с полями для создания кода
	/// </summary>
	public class CodeCreateContract
	{
		/// <summary>
		/// Идентификатор Кода
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Идентификатор Шаблона продукта
		/// </summary>
		public string ProductTemplateId { get; set; }

		/// <summary>
		/// Список аттрибутов
		/// </summary>
		public ICollection<Attribute> Attributes { get; set; }

		/// <summary>
		/// Источник заказа
		/// </summary>
		public string SellSource { get; set; }

		/// <summary>
		/// Идентификатор Магазина
		/// </summary>
		public string StoreId { get; set; }

		/// <summary>
		/// Колличество товара
		/// </summary>
		public long Amount { get; set; }

		/// <summary>
		///Обозначение заказа
		/// </summary>
		public string Symbol { get; set; }

		public CodeCreateContract()
		{
			Id = Identity.NewId();
			Attributes = new List<Attribute>();
		}
	}
}
