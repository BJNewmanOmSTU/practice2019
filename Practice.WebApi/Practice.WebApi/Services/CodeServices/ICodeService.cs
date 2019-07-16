using Practice.WebApi.Contracts.CodeContracts;
using System.Collections.Generic;

namespace Practice.WebApi.Services.CodeServices
{
	/// <summary>
	/// Интерфейс сервиса для работы с Кодами
	/// </summary>
	public interface ICodeService
	{
		/// <summary>
		/// Функция создания Кода
		/// </summary>
		/// <param name="code">Код который нужно создать</param>
		/// <returns>Возвращает созданный Код в виде контракта</returns>
		CodeContract CreateCode(CodeCreateContract code);

		/// <summary>
		/// Функция для получения кода по идентификатору
		/// </summary>
		/// <param name="id">Идентификатор кода</param>
		/// <returns>Возвращает код соответствующий переданному идентификатору</returns>
		CodeContract GetCode(string id);
	}
}
