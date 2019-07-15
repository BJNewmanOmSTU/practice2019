using Practice.Domain;
using Practice.WebApi.Contracts.AttributeContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


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
		[Required(ErrorMessage = "Требуется идентификатор шаблона продукта")]
		public string ProductTemplateId { get; set; }

		/// <summary>
		/// Список аттрибутов
		/// </summary>
		public ICollection<AttributeContract> Attributes { get; set; }

		/// <summary>
		/// Источник заказа
		/// </summary>
		[Required(ErrorMessage = "Требуется требуется указать источник продажи")]
		public string SellSource { get; set; }

		/// <summary>
		/// Идентификатор Магазина
		/// </summary>
		[Required(ErrorMessage = "Требуется идентификатор магазина")]
		public string StoreId { get; set; }

		/// <summary>
		/// Колличество товара
		/// </summary>
		[RegularExpression(@"^[1-9]\d*$", ErrorMessage = "Количество товара должно быть положительным" +
			" и не равным нулю")]
		public long Amount { get; set; }

		/// <summary>
		///Обозначение заказа
		/// </summary>
		public string Symbol { get; set; }

		/// <summary>
		/// Конструктор контракта
		/// </summary>
		public CodeCreateContract()
		{
			Id = Identity.NewId();
			Attributes = new List<AttributeContract>();
			Amount = 1;
		}
	}
}
