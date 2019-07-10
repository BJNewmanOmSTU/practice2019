using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice.Domain;

namespace Practice.WebApi.Contracts.StoreContracts
{
	/// <summary>
	/// Модель контракта Магазина для выдачи данных пользователю
	/// </summary>
	public class StoreContract
	{
		/// <summary>
		/// Идентификатор магазина
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Название магазина
		/// </summary>
		public string Name { get; set; }
	}
}
