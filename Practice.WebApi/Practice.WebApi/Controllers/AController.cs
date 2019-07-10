using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.WebApi.Controllers
{
	/// <summary>
	/// Базовый контроллер
	/// </summary>
	public class AController : Controller
	{
		/// <summary>
		/// Переопреленный метод для обработки ошибок в контроллере
		/// </summary>
		/// <param name="context">Контекст контроллера</param>
		public override void OnActionExecuted(ActionExecutedContext context)
		{
			base.OnActionExecuted(context);

			if( context.Exception != null)
			{
				context.Result = NotFound(context.Exception.Message);
				context.ExceptionHandled = true;
			}
		}
	}
}
