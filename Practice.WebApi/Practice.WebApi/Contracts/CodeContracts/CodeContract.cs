﻿using Practice.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.WebApi.Contracts.CodeContracts
{
	/// <summary>
	/// Модель контракта Кода для выдачи данных пользователю
	/// </summary>
	public class CodeContract
	{
		/// <summary>
		/// Идентификатор Кода
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Название продукта
		/// </summary>
		public string ProductTemplateTitle { get; set; }

		/// <summary>
		/// Источник продажи
		/// </summary>
		public string SellSource { get; set; }

		/// <summary>
		/// Название магазина
		/// </summary>
		public string StoreName { get; set; }

		/// <summary>
		/// Сам код 
		/// </summary>
		public string RedeemCode { get; set; }

		/// <summary>
		/// Статус кода
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		/// Номер транзакции
		/// </summary>
		public string OrderUniqNumber { get; set; }

		/// <summary>
		/// Определяет был ли удален код
		/// </summary>
		public bool Removed { get; set; }

		/// <summary>
		/// Конструктор контракта
		/// </summary>
		public CodeContract()
		{
			RedeemCode = Identity.NewId();
		}
	}
}
