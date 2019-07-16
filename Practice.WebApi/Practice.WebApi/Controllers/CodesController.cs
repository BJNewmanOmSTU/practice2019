using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practice.Domain;
using Practice.WebApi.Contracts.CodeContracts;
using Practice.WebApi.Services.CodeServices;

namespace Practice.WebApi.Controllers
{
	/// <summary>
	/// Контроллер для работы с Кодами
	/// </summary>
	[Route("products/codes")]
	public class CodesController : AController
	{
		private ICodeService _codeService;

		/// <summary>
		/// Конструктор контроллера
		/// </summary>
		/// <param name="codeService">Сервис для работы со Кодами</param>
		public CodesController(CodeService codeService)
		{
			_codeService = codeService;
		}

		/// <summary>
		/// Post метод для обработки запроса
		/// создания нового Кода
		/// </summary>
		/// <param name="code">Объект Кода который нужно создать</param>
		/// <returns>Возвращает созданный объект</returns>
		[HttpPost]
		public ActionResult<CodeContract> Post([FromBody] CodeCreateContract code)
		{
			if (ModelState.IsValid)
			{ 
				return _codeService.CreateCode(code);
			}
			else
			{
				//Возвращает список ошибок возникших при валидации входной модели
				return BadRequest(ModelState.Values.SelectMany(m => m.Errors)
								 .Select(e => e.ErrorMessage)
								 .ToList());
			}
		}

		/// <summary>
		/// Get метод для получения списка кодов (если без параметров),
		/// иначе отфильтрованный по заданным полям
		/// </summary>
		/// <returns>Возвращает список кодов</returns>
		[HttpGet]
		public ActionResult<List<CodeContract>> GetListCodes(CodeFilter filter)
		{
			return _codeService.GetListCodes(filter);
		}
	}
}
