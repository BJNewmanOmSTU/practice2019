using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Practice.WebApi.Services.ProductTemplatesServices
{

	/// <summary>
	/// Определяет ошибку при неверных параметрах модели
	/// </summary>
	public class ModelValidationExсeption : Exception
	{
		private List<ValidationResult> list;

		public ModelValidationExсeption()
		{
		}

		public ModelValidationExсeption(string message) : base(message)
		{
		}

		public ModelValidationExсeption(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected ModelValidationExсeption(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		
	}
}
