using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Domain
{
	/// <summary>
	/// Класс для фильтрации по полям Store
	/// </summary>
	public class StoreFilter
	{
		/// <summary>
		/// Параметр для поиска по начальным символам названия Store
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Параметр для поиска по полному совпадению с названием Store
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Параметр для поиска по подстрокам в названии Store
		/// </summary>
		public string Search { get; set; }
	}
}
