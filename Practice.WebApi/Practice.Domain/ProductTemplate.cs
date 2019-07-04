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
		public string Title { get; set; }
		
		/// <summary>
		/// Внешний ключ Code
		/// </summary>
		public string CodeId { get; set; }

		/// <summary>
		///	Ссылка на модель Code
		/// </summary>
		public Code Code { get; set; }

		/// <summary>
		/// Конструктор класса ProductTemplate. При каждом создании нового экземпляра генерирует идентификатор
		/// </summary>
		public ProductTemplate()
		{
			Id = Identity.NewId();
		}
	}


}
