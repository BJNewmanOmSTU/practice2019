using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Domain
{
	/// <summary>
	///Модель Attribute. Содержит свойства продукта
	///которые клиент может выбирать при покупке продукта.
	/// </summary>
	public class Attribute
	{
		/// <summary>
		///Идентификатор аттрибута
		/// </summary>
		public string Id { get; set; }
		
		/// <summary>
		///Название аттрибута
		/// </summary>
		public string Title { get; set; }
		
		/// <summary>
		/// Значение атрибута
		/// </summary>
		public string Value { get; set; }
		
		/// <summary>
		///  Кооментарий к аттрибуту
		/// </summary>
		public string Comment { get; set; }
		
		/// <summary>
		/// Тип атрибута
		/// </summary>
		public string TypeId { get; set; }
		
		/// <summary>
		///	Внешний ключ на модель Code
		/// </summary>
		public string CodeId { get; set; }
		
		/// <summary>
		///	Ссылка на модель Code
		/// </summary>
		public Code Code { get; set; }

		/// <summary>
		/// Конструктор класса Attribute. При каждом создании нового экземпляра генерирует идентификатор
		/// </summary>
		public Attribute()
		{
			this.Id = Identity.NewId();
		}
	}
}
