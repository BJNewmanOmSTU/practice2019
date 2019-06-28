using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Domain
{
	/// <summary>
	/// Класс для генерации нового идентификатора
	/// </summary>
	public class Identity
	{
		/// <summary>
		/// Генерирует новое значение идентификатора, возвращает 
		/// строку состоящую из 32 знаков, состоящую из букв и цифр.
		/// </summary>
		/// <returns></returns>
		public static string NewId()
		{
			return Guid.NewGuid().ToString("N");
		}
	}
}
