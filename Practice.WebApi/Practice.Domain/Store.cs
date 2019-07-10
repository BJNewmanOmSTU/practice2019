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

<<<<<<< HEAD
		/// <summary>
=======
        /// <summary>
>>>>>>> P2019-26_Add_endpoint_stores
		/// Название магазина
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Коллекция кодов
		/// </summary>
		public List<Code> Codes { get; set; }

		/// <summary>
		/// Конструктор класса Store. При каждом создании нового экземпляра генерирует идентификатор
		/// </summary>
		public Store()
		{
			Id = Identity.NewId();
			Codes = new List<Code>();
		}
	}
}
