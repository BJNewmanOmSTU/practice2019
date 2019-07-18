using System.Collections.Generic;

namespace Practice.WebApi.Contracts.CodeContracts
{
	/// <summary>
	/// Модель содержащая список идентификаторов удаленных кодов
	/// </summary>
	public class DeletedCodes
	{
		/// <summary>
		/// Список идентификаторов удаленных кодов
		/// </summary>
		public List<string> Ids { get; set; }

		/// <summary>
		/// Конструктор класса
		/// </summary>
		public DeletedCodes()
		{
			Ids = new List<string>();
		}
	}
}
