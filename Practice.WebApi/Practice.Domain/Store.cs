using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Domain
{
	/// <summary>
	/// Модель Store. Содержит информацию о магазине.
	/// </summary>
	public class Store
	{
		/// <summary>
		/// Идентификатор магазина
		/// </summary>

		public string Id { get; set; }
		
		/// <summary>
		/// Название магазина
		/// </summary>		
		public string Name { get; set; }

		/// <summary>
		/// Внешний ключ Code
		/// </summary>
		public List<Code> Codes { get; set; }

		/// <summary>
		///	Ссылка на модель Code
		/// </summary>
		public Code Code { get; set; }

		/// <summary>
		/// Конструктор класса Store. При каждом создании нового экземпляра генерирует идентификатор
		/// </summary>
		public Store()
		{
			Id = Identity.NewId();
		}
	}
}
