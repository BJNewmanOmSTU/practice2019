
namespace Practice.WebApi.Contracts.ProductTemplatesContracts
{
	/// <summary>
	/// Модель контракта Шаблона продукта для выдачи данных пользователю
	/// </summary>
	public class ProductTemplateContract
	{
		/// <summary>
		/// Идентификатор Шаблона продукта
		/// </summary>
		public string Id { get; set; }

		// <summary>
		/// Название Шаблона продукта
		/// </summary>
		public string Name { get; set; }
	}
}
