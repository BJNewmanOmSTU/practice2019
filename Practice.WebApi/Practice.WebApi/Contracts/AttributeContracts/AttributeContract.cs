using System.ComponentModel.DataAnnotations;

namespace Practice.WebApi.Contracts.AttributeContracts
{
	/// <summary>
	/// Контракт Аттрибутов
	/// </summary>
	public class AttributeContract
	{
		/// <summary>
		/// Название аттрибута
		/// </summary>
		[Required(ErrorMessage = "Требуется название атрибута")]
		public string Title { get; set; }

		/// <summary>
		/// Значение аттрибута
		/// </summary>
		[Required(ErrorMessage = "Требуется объект, представляющий собой значение атрибута")]
		public string Value { get; set; }

		/// <summary>
		/// Комментарий к аттрибуту
		/// </summary>
		public string Comment { get; set; }

		/// <summary>
		/// Идентификатор типа
		/// </summary>
		[Required(ErrorMessage = "Требуется идентификатор типа атрибута")]
		public string TypeId { get; set; }
	}
}
