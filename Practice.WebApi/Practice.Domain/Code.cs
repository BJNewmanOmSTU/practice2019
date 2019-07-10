using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Domain
{
	/// <summary>
	///Класс модели Кода. Содержит необходимую информацию
	/// для создания заказа на платформе.
	/// </summary>
	/// 
	public class Code
	{
		/// <summary>
		/// Идентификатор кода
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		///Внешний ключ к ProductTemplate
		/// </summary>
		public string ProductTemplateId { get; set; }

		/// <summary>
		///Список аттрибутов модели Attribute
		/// </summary>
		public List<Attribute> Attributes { get; set; }

		/// <summary>
		///Источник заказа
		/// </summary>
		public string SellSource { get; set; }

		/// <summary>
		///Внешний ключ на модель Store
		/// </summary>
		public string StoreId { get; set; }

		/// <summary>
		/// Внешнее свойство на Store
		/// </summary>
		public Store Store { get; set; }

		/// <summary>
		/// Внешнее свойство на ProductTemplate
		/// </summary>
		public ProductTemplate ProductTemplate { get; set; }

		/// <summary>
		///Количество товара в заказе
		/// </summary>
		public long Amount { get; set; }

		/// <summary>
		///Обозначение заказа
		/// </summary>
		public string Symbol { get; set; }

		/// <summary>
		/// Конструктор класса Code. При каждом создании нового экземпляра генерирует идентификатор
		/// </summary>
		public Code()
		{
			Id = Identity.NewId();
			Attributes = new List<Attribute>();
		}
	}
}
