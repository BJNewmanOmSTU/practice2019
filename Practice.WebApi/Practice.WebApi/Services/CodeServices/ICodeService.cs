using Practice.Domain;
using Practice.WebApi.Contracts.CodeContracts;

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
		CodeContract CreateCode(Code code);

	}
}
