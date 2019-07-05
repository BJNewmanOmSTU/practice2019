using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Domain
{
	/// <summary>
	/// Модель ProductTemolate. 
	/// </summary>
	public class ProductTemplate
	{
		/// <summary>
		/// Идентификатор ProductTemplate
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Название ProductTemplate
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Коллекция кодов
		/// </summary>
		public List<Code> Codes { get; set; }

		/// <summary>
		/// Конструктор класса ProductTemplate. При каждом создании нового экземпляра генерирует идентификатор
		/// </summary>
		public ProductTemplate()
		{
			Id = Identity.NewId();
			Codes = new List<Code>();
		}
	}


}
