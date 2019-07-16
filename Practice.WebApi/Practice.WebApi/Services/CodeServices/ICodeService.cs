using Practice.Domain;
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
		/// Функция удаления кодов
		/// </summary>
		/// <param name="ids">Строка содержащая список идентификаторов
		/// разделенными запятой</param>
		/// <returns>Возвращает список удаленных кодов</returns>
		DeletedCodes DeleteCodes(string ids);
	}
}
