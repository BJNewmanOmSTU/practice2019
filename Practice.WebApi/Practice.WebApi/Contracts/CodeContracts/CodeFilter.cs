namespace Practice.WebApi.Contracts.CodeContracts
{
	/// <summary>
	/// Класс содержащий поля
	/// для фильтрации списка кодов
	/// </summary>
	public class CodeFilter
	{
		/// <summary>
		/// Поиск кодов по id шаблона продукта
		/// </summary>
		public string ProductTemplateId { get; set; }

		/// <summary>
		/// Поиск кодов источнику продажи
		/// </summary>
		public string SellSource { get; set; }

		/// <summary>
		/// Поиск кодов id магазина
		/// </summary>
		public string StoreId { get; set; }

		/// <summary>
		/// Поиск кодов по их статусу
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		/// Поиск по всем видимым полям на странице
		/// </summary>
		public string Search { get; set; }
	}
}
