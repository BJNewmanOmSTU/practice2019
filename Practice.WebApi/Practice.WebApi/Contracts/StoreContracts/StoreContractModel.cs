using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice.Domain;

namespace Practice.WebApi.Contracts.StoreContracts
{
	/// <summary>
	/// Модель контракта Store для выдачи данных пользователю
	/// </summary>
	public class StoreContractModel
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
