using System.Collections.Generic;

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
		///Внешний ключ на Шаблон продукта
		/// </summary>
		public string ProductTemplateId { get; set; }

		/// <summary>
		///Список аттрибутов модели
		/// </summary>
		public ICollection<Attribute> Attributes { get; set; }

		/// <summary>
		///Источник заказа
		/// </summary>
		public string SellSource { get; set; }

		/// <summary>
		///Внешний ключ на Магазин
		/// </summary>
		public string StoreId { get; set; }

		/// <summary>
		/// Внешнее свойство на Магазин
		/// </summary>
		public Store Store { get; set; }

		/// <summary>
		/// Внешнее свойство на Шаблон продукта
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
		/// Статус кода
		/// </summary>
		public StatusEnum Status { get; set; }

		/// <summary>
		/// Номер заказа
		/// </summary>
		public string OrderUniqNumber { get; set; }

		/// <summary>
		/// Определяет был ли удален код
		/// </summary>
		public bool Removed { get; set; }

		/// <summary>
		/// Сам код
		/// </summary>
		public string RedeemCode { get; set; }

		/// <summary>
		/// Конструктор класса Code. При каждом создании нового экземпляра генерирует идентификатор
		/// </summary>
		public Code()
		{
			Id = Identity.NewId();
			Attributes = new List<Attribute>();
			OrderUniqNumber = Identity.NewId();
			RedeemCode = Identity.NewId();
			Status = StatusEnum.Active;
            Removed = false;
		}
    }

	/// <summary>
	/// Список статусов
	/// </summary>
	public enum StatusEnum {
		Active,
		Redeemed,
		Completed
	}
}
