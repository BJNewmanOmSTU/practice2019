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
		public ICollection<Attribute> Attributes { get; set; }
		/// <summary>
		///Источник заказа
		/// </summary>
		public string SellSource { get; set; }
		/// <summary>
		///Внешний ключ на модель Store
		/// </summary>
		public string StoreId { get; set; }
		/// <summary>
		///Количество товара в заказе
		/// </summary>
		public long Amount { get; set; }
		/// <summary>
		///Обозначение заказа
		/// </summary>
		public string Symbol { get; set; }

		public Code()
		{
			Id = Guid.NewGuid().ToString("N");
			Attributes = new List<Attribute>();
		}
	}
}
